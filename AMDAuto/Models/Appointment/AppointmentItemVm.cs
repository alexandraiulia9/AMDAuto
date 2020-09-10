using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AMDAuto.Models
{
    public class AppointmentItemVm
    {
        public Guid Id { get; set; }
        public string CarModel { get; set; }
        public string CarMake { get; set; }
        public string OperationName { get; set; }

        public DateTimeOffset? ScheduledOn { get; set; }
        public string ScheduledOnDisplay { get; set; }
        public Guid StatusId { get; set; }
        public string StatusName { get; set; }
        public Guid EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public bool IsEditable { get; set; }
        public List<SelectListItem> Statuses { get; set; }
    }
}
