using System;

namespace LMS.Domain
{
    public class Chapter
    {
        public Guid Id { get; set; }
        public Course Course { get; set; }
        public int Number { get; set; }
        public string Title { get; set; }
    }
}
