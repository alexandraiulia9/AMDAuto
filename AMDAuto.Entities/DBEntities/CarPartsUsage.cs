﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Common.Interfaces;
using System;
using System.Collections.Generic;

namespace AMDAuto.Entities
{
    public partial class CarPartsUsage : IEntity
    {
        public Guid PartId { get; set; }
        public int? Quantity { get; set; }
        public Guid AppointmentId { get; set; }

        public virtual Appointments Appointment { get; set; }
        public virtual CarParts Part { get; set; }
    }
}