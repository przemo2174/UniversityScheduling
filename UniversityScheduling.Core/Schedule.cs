using System;
using System.Collections.Generic;

namespace UniversityScheduling.Core
{
    public class Schedule
    {
        public string Major { get; set; } //Field of study
        public int Year { get; set; }
        public List<User> Students { get; set; }
        public List<Course> Classes { get; set; }
    }
}
