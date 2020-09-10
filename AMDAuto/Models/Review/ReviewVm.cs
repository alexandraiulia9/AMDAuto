using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AMDAuto.Models
{
    public class ReviewVm
    {

        public ReviewVm()
        {
            Reviews = new List<ReviewItemVm>();
        }
        public List<ReviewItemVm> Reviews { get; set; }
    }
}
