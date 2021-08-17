using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPages.Model
{
    public class Course
    {
        public string CourseID { get; set; }
        public string CourseTitle { get; set; }
        public int Duration { get; set; }
        public string Owner { get; set; }
        public string AssessmentMode { get; set; }
    }
}
