﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Common.Interfaces;
using System;
using System.Collections.Generic;

namespace AMDAuto.Entities
{
    public partial class Operations : IEntity
    {
        public Operations()
        {
            Appointments = new HashSet<Appointments>();
            CarOperations = new HashSet<CarOperations>();
            CarParts = new HashSet<CarParts>();
            PastAppointments = new HashSet<PastAppointments>();
        }

        public Guid Id { get; set; }
        public double? Price { get; set; }
        public int? Duration { get; set; }
        public string Name { get; set; }
        public int? CategoryId { get; set; }

        public virtual Categories Category { get; set; }
        public virtual ICollection<Appointments> Appointments { get; set; }
        public virtual ICollection<CarOperations> CarOperations { get; set; }
        public virtual ICollection<CarParts> CarParts { get; set; }
        public virtual ICollection<PastAppointments> PastAppointments { get; set; }
    }
}