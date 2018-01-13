using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;
using UniversityScheduling.Core.Enums;

namespace UniversityScheduling.Core
{
    public class Slot
    {
        public int Id { get; set; }
        public Day Day { get; set; }
        public int Number { get; set; }
        public int RoomId { get; set; }
        public int SubjectId { get; set; }
    }
}
