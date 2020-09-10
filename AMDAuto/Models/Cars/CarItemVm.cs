using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AMDAuto.Models
{
    public class CarItemVm
    {
      
        public Guid Id { get; set; }
        public string MakeNameId { get; set; }
        public string ModelNameId { get; set; }

        public string LicenseNumber { get; set; }
        public Guid UserId { get; set; }

        public int ReleaseYear { get; set; }

    }
}
