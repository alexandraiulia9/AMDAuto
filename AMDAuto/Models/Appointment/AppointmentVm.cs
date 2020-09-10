using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AMDAuto.Models
{
    public class AppointmentVm
    {
        public AppointmentVm()
        {
            Cars = new List<SelectListItem>();
            Categories = new List<SelectListItem>();
            Operations = new List<SelectListItem>();
        }
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Selectati masina pentru care doriti sa faceti programarea!")]
        public Guid CarId { get; set; }
        public Guid? UserId { get; set; }
        public Guid? EmployeeId { get; set; }
        public List<SelectListItem> Cars { get; set; }
        [Required(ErrorMessage = "Selectati categoria!")]
        public int? CategoryId { get; set; }
        public List<SelectListItem> Categories { get; set; }
        public Guid? OperationId { get; set; }
        public List<SelectListItem> Operations { get; set; }
        //public DateTimeOffset ScheduledOn { get; set; }
     
    }
}
