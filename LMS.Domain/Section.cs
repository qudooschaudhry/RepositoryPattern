using System;

namespace LMS.Domain
{
    public class Section
    {
        public Guid Id { get; set; }
        public Page Page { get; set; }
        public int Number { get; set; }
        public string Heading { get; set; }
        public Content Content { get; set; }
    }
}
