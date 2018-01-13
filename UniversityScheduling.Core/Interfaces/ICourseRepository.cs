using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityScheduling.Core.Interfaces
{
    public interface ICourseRepository
    {
        Course GetById(int id);
    }
}
