using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AMDAuto.Models
{
    public class EmployeePastAppointmentsVm
    {
        public EmployeePastAppointmentsVm()
        {
            PastAppointments = new List<PastAppointmentItemVm>();
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<PastAppointmentItemVm> PastAppointments { get; set; }
    }
}
