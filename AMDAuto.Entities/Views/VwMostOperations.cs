﻿using Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AMDAuto.Entities.Views
{
    public class VwMostOperations : IEntity
    {
        public string Name { get; set; }
        public int usedNumber { get; set; }
    }
}
