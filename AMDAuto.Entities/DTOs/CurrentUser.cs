using System;
using System.Collections.Generic;
using System.Text;

namespace AMDAuto.Entities.DTOs
{
    public class CurrentUser
    {
        public CurrentUser(bool isAuthenticated)
        {
            IsAuthenticated = isAuthenticated;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public bool IsAuthenticated { get; set; }
        public Guid RoleId { get; set; }
    }
}
