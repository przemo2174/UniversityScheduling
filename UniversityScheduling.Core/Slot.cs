using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;
using UniversityScheduling.Core.Enums;

namespace UniversityScheduling.Core
{
    public class Slot
    {
        private int id;
        public int Id
        {
            get => id;
            set
            {
                id = value;

                int dayOfWeek = (id - 1) / 16;
                switch (dayOfWeek)
                {
                    case 0:
                        Day = Day.Monday;
                        break;
                    case 1:
                        Day = Day.Tuesday;
                        break;
                    case 2:
                        Day = Day.Wednesday;
                        break;
                    case 3:
                        Day = Day.Thursday;
                        break;
                    case 4:
                        Day = Day.Friday;
                        break;
                }
            }
        }
        public Day Day { get; private set; }
        public int Number { get; set; }
        public int RoomId { get; set; }
        public int SubjectId { get; set; }
    }
}
