using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AMDAuto.Models
{
    public class PhotoVM
    {
        public Guid Id { get; set; }

        public byte[] Content { get; set; }
    }
}
