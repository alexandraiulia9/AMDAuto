﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Common.Interfaces;
using System;
using System.Collections.Generic;

namespace AMDAuto.Entities
{
    public partial class Comments : IEntity
    {
        public Guid Id { get; set; }
        public Guid? ReviewId { get; set; }
        public Guid? UserId { get; set; }
        public string Content { get; set; }

        public virtual Reviews Review { get; set; }
        public virtual Users User { get; set; }
    }
}