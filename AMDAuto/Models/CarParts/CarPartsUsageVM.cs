﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AMDAuto.Models
{
    public class CarPartsUsageVM
    {
        public Guid PartId { get; set; }
        public string Name { get; set; }

        public int? Quantity {get; set;}
    }
}
