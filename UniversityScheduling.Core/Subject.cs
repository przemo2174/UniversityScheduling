using System;
using System.Collections.Generic;
using System.Text;
using UniversityScheduling.Core.Enums;

namespace UniversityScheduling.Core
{
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Duration { get; set; }
        public int InstructorId { get; set; }
        public SubjectType Type { get; set; }
    }
}
