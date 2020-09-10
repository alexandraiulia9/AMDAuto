using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AMDAuto.Models
{
    public class OperationVm
    {
        public OperationVm()
        {
            Categories = new List<SelectListItem>();
        }
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        [Required]
        public float Price { get; set; }
        [Required]
        public int Duration { get; set; }
        public List<SelectListItem> Categories { get; set; }
    }
}
