using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace UniversityScheduling.Core
{
    public class Course // Kierunek
    {
        public int Id { get; set; }
        public int StudentSize { get; set; }
        public List<Subject> Subjects { get; set; }
    }
}
