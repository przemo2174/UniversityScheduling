using System;
using System.Collections.Generic;

namespace UniversityScheduling.Core
{
    public class Schedule
    {
        public string Major { get; set; } //Field of study
        public List<User> Students { get; set; }
        public List<Class> Classes { get; set; }
    }
}
