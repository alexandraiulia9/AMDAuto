using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AMDAuto.Models
{
    public class DateEvents
    {
        public Guid Id { get; set; }
        public string EmployeeName { get; set; }
        public string Title { get; set; }
        public DateTimeOffset? Start { get; set; }
        public DateTimeOffset? End { get; set; }
        public int? Duration { get; set; }
        public bool AllDay { get; set; }
    }
}
