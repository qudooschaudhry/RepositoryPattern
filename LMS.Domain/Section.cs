using System;

namespace LMS.Domain
{
    public class Section
    {
        public Guid Id { get; set; }
        public Chapter Chapter { get; set; }
        public int Number { get; set; }
        public string Heading { get; set; }
        public string Content { get; set; }
    }
}
