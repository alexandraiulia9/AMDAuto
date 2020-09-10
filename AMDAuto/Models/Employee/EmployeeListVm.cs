using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AMDAuto.Models
{
    public class EmployeeListVm
    {
        public List<EmployeeItemVm> EmployeeList { get; set; }
        public bool IsLastPage { get; set; }
        public EmployeeListVm()
        {
            EmployeeList = new List<EmployeeItemVm>();
        }
    }
}
