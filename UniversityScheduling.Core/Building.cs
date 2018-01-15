using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityScheduling.Core
{
    public class Building
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Room> Rooms { get; set; }
    }
}
