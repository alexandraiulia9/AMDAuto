﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Common.Interfaces;
using System;
using System.Collections.Generic;

namespace AMDAuto.Entities
{
    public partial class ModelNames : IEntity
    {
        public ModelNames()
        {
            Cars = new HashSet<Cars>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int MakeId { get; set; }

        public virtual MakeNames Make { get; set; }
        public virtual ICollection<Cars> Cars { get; set; }
    }
}