using System;
using System.Collections.Generic;
using System.Text;
using UniversityScheduling.Core.Interfaces;

namespace UniversityScheduling.Core.Repositories
{
    public class RoomsRepository : IRoomsRepository
    {
        public int Count { get; }

        public IEnumerable<Room> GetAll()
        {
            throw new NotImplementedException();
        }

        public Room GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
