using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AMDAuto.Models
{ 
    public class UserPastAppointmentsVm
    {
        public UserPastAppointmentsVm()
        {
            PastAppointmentsList = new List<PastAppointmentItemVm>();
        }

       public List<PastAppointmentItemVm> PastAppointmentsList;
    }
}
