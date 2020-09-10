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
using System.Linq;
using System.Threading.Tasks;

namespace AMDAuto.Controllers
{
    public class CommentController : BaseController
    {
        public ReviewService reviewService{ get; set; }
        private readonly CommentService commentService;
        public CommentController(ReviewService reviewService, CommentService commentService, IMapper mapper) : base(mapper)
        {
            this.reviewService = reviewService;
            this.commentService = commentService;
        }

        [HttpGet]
        public IActionResult AddComment()
        {
            return View();
        }

        //[HttpPost]
        //public IActionResult AddComment()
        //{
        //    return View();
        //}
        public IActionResult GetReviewById(Guid id)
        {
            var review =  reviewService.GetReviewById(id);
            return Json(review);
        }

        [Authorize]
        [HttpPost]
        public IActionResult DeleteComment(Guid id)
        {
            var comment = commentService.DeleteComment(id);
            if (!comment)
            {
                return InternalServerErrorView();
            }
            return Ok();
        }

        [HttpGet]
        public IActionResult EditComment(Guid id)
        {
            var entity = commentService.GetCommentById(id);
            var model = mapper.Map<CommentVm>(entity);
            return View(model);
        }

        [HttpPost]
        public IActionResult EditComment(CommentVm model)
        {
            var entity = mapper.Map<Comments>(model);
            var result = commentService.UpdateComment(entity);
            if (!result)
            {
                return InternalServerErrorView();
            }
            return RedirectToAction("ViewReviews", "Review");
        }
    }
}
