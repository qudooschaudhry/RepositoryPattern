using System;
using System.Collections.Generic;

namespace LMS.Domain
{
    public class Chapter
    {
        public Guid Id { get; set; }
        public Guid CourseId { get; set; }
        public Course Course { get; set; }
        public int Number { get; set; }
        public string Title { get; set; }
        public List<Page> Pages { get; set; } = new List<Page>();
    }
}
