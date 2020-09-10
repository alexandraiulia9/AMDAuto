using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AMDAuto.Models
{
    public class EmployeeScheduleVM
    {
        public EmployeeScheduleVM()
        {
            Appointments = new List<DateEvents>();
            PendingAppointments = new List<DateEvents>();
        }
        public List<DateEvents> Appointments { get; set; }
        public List<DateEvents> PendingAppointments { get; set; }
    }

}
