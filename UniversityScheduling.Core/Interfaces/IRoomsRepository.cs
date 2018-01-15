using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityScheduling.Core.Interfaces
{
    public interface IRoomsRepository
    {
        int Count { get; }
        IEnumerable<Room> GetAll();
        Room GetById(int id);
    }
}
