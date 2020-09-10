using AMDAuto.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AMDAuto.Models
{
    public class PastAppointmentItemVm
    {
        public PastAppointmentItemVm()
        {
            Parts = new List<PartVm>();
        }
        public Guid Id { get; set; }
        public string CarModel { get; set; }
        public string CarMake { get; set; }
        public Guid OperationId { get; set; }
        public string OperationName { get; set; }
        public float OperationPrice { get; set; }
        public string EmployeeName { get; set; }
        public DateTimeOffset ScheduledOn { get; set; }
        public string ScheduledOnDisplay { get; set; }
        public string Status { get; set; }
        public int Quantity { get; set; }
        public List<PartVm> Parts { get; set; }
        public double PartsPrice { get; set; }
    }
}
