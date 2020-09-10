using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AMDAuto.Models
{
    public class EmployeeFutureAppointmentsVm
    {
        public EmployeeFutureAppointmentsVm()
        {
            FutureAppointments = new List<AppointmentItemVm>();
        }
        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public List<AppointmentItemVm> FutureAppointments { get; set; }
    }
}
