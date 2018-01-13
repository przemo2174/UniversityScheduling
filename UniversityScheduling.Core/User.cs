using System;
using System.Collections.Generic;
using System.Text;
using UniversityScheduling.Core.Enums;

namespace UniversityScheduling.Core
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public UserType UserType { get; set; }
    }
}
