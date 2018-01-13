using System;
using System.Collections.Generic;
using System.Text;
using UniversityScheduling.Core.Enums;
using UniversityScheduling.Core.Interfaces;

namespace UniversityScheduling.Core.Repositories
{
    public class BuildingRepository : IBuildingsRepository
    {
        private List<Building> buildings = new List<Building>
        {
            new Building
            {
                Rooms = new List<Room>
                {
                    new Room
                    {
                        Id = 1,
                        Capacity = 30,
                        Type = SubjectType.Exercise,
                        Slots = new List<Slot>
                        {
                            new Slot
                            {
                                Id = 1,
                                Day = Day.Monday
                            }
                        }
                    }
                }
            }
                
        };

        public Building GetById(int id)
        {
            return null;
        }
    }
}
