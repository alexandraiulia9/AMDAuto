using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AMDAuto.Models
{
    public class UserListVm
    {
        public List<UserVm> UserList { get; set; }
        //public bool IsLastPage { get; set; }
        public UserListVm()
        {
            UserList = new List<UserVm>();
        }

    }
}
