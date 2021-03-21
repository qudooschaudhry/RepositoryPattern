using System;
using System.Collections.Generic;

namespace LMS.Domain
{
    public class Student
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Course> Courses { get; set; } = new List<Course>();

    }
}
