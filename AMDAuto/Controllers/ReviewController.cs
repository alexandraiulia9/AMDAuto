using AMDAuto.Code.Base;
using AMDAuto.Entities;
using AMDAuto.Models;
using AMDAuto.Services.Comment;
using AMDAuto.Services.Review;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AMDAuto.Controllers
{
    public class ReviewController : BaseController
    {
        private readonly ReviewService reviewService;
        private readonly CommentService commentService;
        public ReviewController(CommentService commentService, ReviewService reviewService, IMapper mapper) : base(mapper)
        {
            this.commentService = commentService;
            this.reviewService = reviewService;
        }

        public IActionResult ViewReviews()
        {
            var entities = reviewService.GetAll();
            var reviews = entities.Select(r => mapper.Map<ReviewItemVm>(r)).ToList();
            foreach(var r in reviews)
            {
                var comments = commentService.GetCommentsByReviewId(r.Id);
                var commentModel = comments.Select(c => mapper.Map<CommentVm>(c)).ToList();
                r.Comments = commentModel;
            }
            var model = new ReviewVm();
            model.Reviews = reviews;
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> AddReview()
        {
            var model = new AddReviewVM() {

                CreatedOn = DateTimeOffset.Now
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AddReview(AddReviewVM model)
        {
            model.CreatedOn = DateTimeOffset.Now;
            var entity = mapper.Map<Reviews>(model);
            var result = reviewService.AddReview(entity);
            if (!result)
            {
                return InternalServerErrorView();
            }
            return RedirectToAction("ViewReviews", "Review");
        }

        [Authorize]
        [HttpPost]
        public IActionResult DeleteReview(Guid id)
        {
            var result = reviewService.DeleteReview(id);
           
            if (!result)
            {
                return InternalServerErrorView();
            }
            return Ok();

        }

        [HttpGet]
        public IActionResult EditReview(Guid id)
        {
            var entity = reviewService.GetReviewById(id);
            var model = mapper.Map<AddReviewVM>(entity);
            return View(model);
        }

        [HttpPost]
        public IActionResult EditReview(AddReviewVM model)
        {
            var entity = mapper.Map<Reviews>(model);
            var result = reviewService.UpdateReview(entity);
            if (!result)
            {
                return InternalServerErrorView();
            }
            return RedirectToAction("ViewReviews", "Review");
        }

        [HttpPost]
        public IActionResult AddCommentToReview(Guid id, string content)
        {
            
            var result = commentService.AddComment(id, content);
            if (!result)
            {
                return InternalServerErrorView();
            }

            return RedirectToAction("ViewReviews", "Review");
        }
    }
}
