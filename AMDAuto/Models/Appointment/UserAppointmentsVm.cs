using AMDAuto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AMDAuto.Models
{
    public class UserAppointmentsVm
    {
        public UserAppointmentsVm()
        {
            UserAppointments = new List<AppointmentItemVm>();

        }

        public Guid UserId { get; set; }
        public List<AppointmentItemVm> UserAppointments { get; set; }
    }
}
