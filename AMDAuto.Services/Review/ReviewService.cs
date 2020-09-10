using AMDAuto.DataAccess.UnitOfWork;
using AMDAuto.Entities;
using AMDAuto.Entities.DTOs;
using AMDAuto.Services.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AMDAuto.Services.Review
{
    public class ReviewService : BaseService
    {
        private readonly CurrentUser currentUser;
        public ReviewService(CurrentUser currentUser, AMDAutoUnitOfWork unitOfWork) : base(unitOfWork)
        {
            this.currentUser = currentUser;

        }

        public List<Reviews> GetAll()
        {
            return UnitOfWork.Reviews
                .Query
                .Include(r => r.User)
                .ToList();

        }

        public Reviews GetReviewById(Guid id)
        {
            return UnitOfWork.Reviews.Query.Where(r => r.Id == id).FirstOrDefault();
        }

        public bool AddReview(Reviews review)
        {
            review.Id = Guid.NewGuid();
            review.UserId = currentUser.Id;
            UnitOfWork.Reviews.Add(review);

            return UnitOfWork.SaveChanges();

        }

        public bool DeleteReview(Guid id)
        {
            var review = UnitOfWork.Reviews.Query.FirstOrDefault(r => r.Id == id);
            if (review != null)
            {
                var comments = UnitOfWork.Comments.Query.Where(c => c.ReviewId == review.Id);
                if (comments != null)
                {
                    UnitOfWork.Comments.RemoveRange(comments);
                }
                UnitOfWork.Reviews.Remove(review);
            }
           
            return UnitOfWork.SaveChanges();
        }

        public bool UpdateReview(Reviews review)
        {

            var existingPost = UnitOfWork.Reviews.Query.FirstOrDefault(r => r.Id == review.Id);
            existingPost.Content = review.Content;
            existingPost.CreatedOn = DateTime.Now;
            return UnitOfWork.SaveChanges();


        }
    }
}
