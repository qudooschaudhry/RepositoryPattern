using System;
using System.Collections.Generic;

namespace LMS.UI.Models
{
    public class CourseDetailsViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<ChapterViewModel> Chapters = new List<ChapterViewModel>();
    }

    public class ChapterViewModel 
    {
        public Guid Id { get; set; }
        public int ChapterNumber { get; set; }
        public string Title { get; set; }
    }
}
