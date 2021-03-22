using System;
using System.Collections.Generic;

namespace LMS.Domain
{
    public class Course : IRootAggregate
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public List<Student> Students { get; set; } = new List<Student>();
    }
}
