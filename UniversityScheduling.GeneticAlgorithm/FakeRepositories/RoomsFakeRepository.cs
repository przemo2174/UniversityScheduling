using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UniversityScheduling.Core;
using UniversityScheduling.Core.Enums;
using UniversityScheduling.Core.Interfaces;

namespace UniversityScheduling.GeneticAlgorithm.FakeRepositories
{
    public class RoomsFakeRepository : IRoomsRepository
    {
        private readonly List<Room> _rooms = new List<Room>()
        {
            new Room()
            {
                Id = 1,
                Name = "D6/201",
                Type = SubjectType.Lecture,
                Capacity = 100
            },
            new Room()
            {
                Id = 2,
                Name = "D6/L1",
                Type = SubjectType.Laboratory,
                Capacity = 30
            },
            new Room()
            {
                Id = 3,
                Name = "D6/L3",
                Type = SubjectType.Laboratory,
                Capacity = 15
            },
            new Room()
            {
                Id = 4,
                Name = "D6/L2",
                Type = SubjectType.Laboratory,
                Capacity = 15
            },
            new Room()
            {
                Id = 5,
                Name = "D13/330",
                Type = SubjectType.Laboratory,
                Capacity = 30
            },
            new Room()
            {
                Id = 6,
                Name = "D5/06",
                Type = SubjectType.Exercise,
                Capacity = 12
            }
        };

        public int Count => _rooms.Count;

        public IEnumerable<Room> GetAll()
        {
            return _rooms;
        }

        public Room GetById(int id)
        {
            return _rooms.Single(x => x.Id == id);
        }
    }
}
