﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Common.Interfaces;
using System;
using System.Collections.Generic;

namespace AMDAuto.Entities
{
    public partial class MakeNames : IEntity
    {
        public MakeNames()
        {
            Cars = new HashSet<Cars>();
            ModelNames = new HashSet<ModelNames>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Cars> Cars { get; set; }
        public virtual ICollection<ModelNames> ModelNames { get; set; }
    }
}