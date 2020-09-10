using AMDAuto.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AMDAuto.Models
{
    public class AppointmentDetailsVm
    {
        public Guid Id { get; set; }
        public Guid OperationId { get; set; }
        public string OperationName { get; set; }
        public Guid PartId { get; set; }
        public Guid StatusId { get; set; }
        public Guid EmployeeId { get; set; }
        public List<SelectListItem> PartsToSelect { get; set; }
        public List<CarPartsUsageVM> PartsUsed { get; set; }
        public List<SelectListItem> Statuses { get; set; }

    }
}
