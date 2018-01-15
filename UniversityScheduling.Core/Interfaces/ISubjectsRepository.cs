using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityScheduling.Core.Interfaces
{
    public interface ISubjectsRepository
    {
        int Count { get; }
        Subject GetById(int id);
    }
}
