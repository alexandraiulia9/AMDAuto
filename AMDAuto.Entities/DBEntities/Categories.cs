﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Common.Interfaces;
using System;
using System.Collections.Generic;

namespace AMDAuto.Entities
{
    public partial class Categories : IEntity
    {
        public Categories()
        {
            Appointments = new HashSet<Appointments>();
            Operations = new HashSet<Operations>();
            PastAppointments = new HashSet<PastAppointments>();
        }

        public string Name { get; set; }
        public int Id { get; set; }

        public virtual ICollection<Appointments> Appointments { get; set; }
        public virtual ICollection<Operations> Operations { get; set; }
        public virtual ICollection<PastAppointments> PastAppointments { get; set; }
    }
}