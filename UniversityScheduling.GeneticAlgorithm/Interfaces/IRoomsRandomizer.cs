using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using UniversityScheduling.Core;

namespace UniversityScheduling.GeneticAlgorithm.Interfaces
{
    public interface IRoomsRandomizer
    {
        Room GetRandomRoom();
    }
}
