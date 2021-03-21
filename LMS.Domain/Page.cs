using System;
using System.Collections.Generic;

namespace LMS.Domain
{
    public class Page
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public Chapter Chapter { get; set; }
        public List<Section> Sections { get; set; } = new List<Section>();
    }
}
