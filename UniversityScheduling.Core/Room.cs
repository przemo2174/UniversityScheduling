using System;
using System.Collections.Generic;
using System.Text;
using UniversityScheduling.Core.Enums;

namespace UniversityScheduling.Core
{
    public class Room
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public SubjectType Type { get; set; }
        public List<Slot> Slots { get; set; } //Busy slots
    }
}
