using System;
using System.Collections.Generic;
using System.Text;
using UniversityScheduling.Core.Enums;

namespace UniversityScheduling.Core
{
    public class Subject
    {
        public int Id { get; set; }
        public int Duration { get; set; }
        public int LecturerId { get; set; }
        public SubjectType Type { get; set; }
    }
}
