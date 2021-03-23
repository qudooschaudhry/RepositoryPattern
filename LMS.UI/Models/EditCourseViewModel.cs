using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.UI.Models
{
    public class EditCourseViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate  { get; set; }
        public DateTime EndDate { get; set; }
    }
}
