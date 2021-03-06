﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Common.Interfaces;
using System;
using System.Collections.Generic;

namespace AMDAuto.Entities
{
    public partial class Appointments : IEntity
    {
        public Appointments()
        {
            CarPartsUsage = new HashSet<CarPartsUsage>();
        }

        public Guid Id { get; set; }
        public Guid? CarId { get; set; }
        public Guid? OperationId { get; set; }
        public string Status { get; set; }
        public string ApprovalStatus { get; set; }
        public DateTimeOffset? ScheduledOn { get; set; }
        public Guid? UserId { get; set; }
        public int? CategoryId { get; set; }
        public Guid? EmployeeId { get; set; }

        public virtual Cars Car { get; set; }
        public virtual Categories Category { get; set; }
        public virtual Employees Employee { get; set; }
        public virtual Operations Operation { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<CarPartsUsage> CarPartsUsage { get; set; }
    }
}