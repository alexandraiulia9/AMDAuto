using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AMDAuto.Models
{
    public class PendingAppointmentsList
    {
        public PendingAppointmentsList()
        {
            PendingAppointments = new List<AppointmentItemVm>();
        }
        public List<AppointmentItemVm> PendingAppointments { get; set; }
    }
}
