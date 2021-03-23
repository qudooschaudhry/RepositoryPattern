using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.UI.Models
{
    public class CourseItemModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime Startdate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
