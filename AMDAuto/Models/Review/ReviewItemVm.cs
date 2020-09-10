using AMDAuto.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AMDAuto.Models
{
    public class ReviewItemVm
    {
        public ReviewItemVm()
        {
            this.Comments = new List<CommentVm>();
        }
        public Guid Id { get; set; }
        public Guid? UserId { get; set; }
        public string UserName { get; set; }
        public string Content { get; set; }
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTimeOffset? CreatedOn { get; set; }

        public string CreatedOnDisplay { get; set; }
        public List<CommentVm> Comments { get; set; }
    }
}
