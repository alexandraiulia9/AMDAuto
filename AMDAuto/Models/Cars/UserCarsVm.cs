using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AMDAuto.Models
{
    public class UserCarsVm
    {
        public UserCarsVm()
        {
            UserCars = new List<CarItemVm>();
        }

        public Guid? UserId { get; set; }
        public List<CarItemVm> UserCars { get; set; }
    }
}
