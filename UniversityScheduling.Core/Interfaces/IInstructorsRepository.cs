using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityScheduling.Core.Interfaces
{
    public interface IInstructorsRepository
    {
        User GetById(int id);
    }
}
