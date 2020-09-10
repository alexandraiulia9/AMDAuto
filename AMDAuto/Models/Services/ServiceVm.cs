using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AMDAuto.Models
{
    public class ServiceVm
    {
        public ServiceVm()
        {
            Categories = new List<SelectListItem>();
            Operations = new List<SelectListItem>();
        }

        [Required(ErrorMessage = "Selectati categoria!")]
        public int CategoryId { get; set; }
        public int OperationId { get; set; }
        public List<SelectListItem> Categories { get; set; }
        public List<SelectListItem> Operations { get; set; }
    }
}
