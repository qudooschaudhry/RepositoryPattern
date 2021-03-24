using System;
using System.Collections.Generic;

namespace LMS.Domain
{
    public class Course : IRootAggregate
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<Student> Students { get; set; } = new List<Student>();

        public void Update(string name, string description)
        {
            //dont really care about all the properties
            Name = name;
            Description = description;
        }
    }
}
