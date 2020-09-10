using AMDAuto.DataAccess.UnitOfWork;
using AMDAuto.Entities;
using AMDAuto.Entities.DTOs;
using AMDAuto.Services.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AMDAuto.Services.Comment
{
    public class CommentService : BaseService
    {
        private readonly CurrentUser currentUser;
        public CommentService(CurrentUser currentUser, AMDAutoUnitOfWork unitOfWork) : base(unitOfWork)
        {
            this.currentUser = currentUser;
        }

        public bool AddComment(Guid reviewId, string comment)
        {
            var newComment = new Comments();
            newComment.Id = Guid.NewGuid();
            newComment.ReviewId = reviewId;
            newComment.UserId = currentUser.Id;
            newComment.Content = comment;

            UnitOfWork.Comments.Add(newComment);

            return UnitOfWork.SaveChanges();

        }

        public List<Comments> GetCommentsByReviewId(Guid id)
        {
            return UnitOfWork.Comments.Query
                .Where(c => c.ReviewId == id)
                .Include(c => c.User)
                .ToList();
        }

        public Comments GetCommentById(Guid id)
        {
            return UnitOfWork.Comments.Query.Where(c => c.Id == id).FirstOrDefault();
        }

        public bool DeleteComment(Guid id)
        {
            var comment = UnitOfWork.Comments.Query.FirstOrDefault(c => c.Id == id);
            if(comment != null)
            {
                UnitOfWork.Comments.Remove(comment);
            }
            return UnitOfWork.SaveChanges();
        }

        public bool UpdateComment(Comments comment)
        {
            var existingComment = UnitOfWork.Comments.Query.FirstOrDefault(c => c.Id == comment.Id);
            existingComment.Content = comment.Content;
            return UnitOfWork.SaveChanges();
        }
    }
}
