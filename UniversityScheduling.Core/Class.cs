using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace UniversityScheduling.Core
{
    public class Class
    {
        public string Name { get; set; }
        public User Instructor { get; set; }
        public Room Room { get; set; }
    }
}
