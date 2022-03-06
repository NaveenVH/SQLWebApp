using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SQLWebApp.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public decimal Rating { get; set; }
    }
}
