using System;
using System.Collections.Generic;
using System.Text;
using UniversityScheduling.Core;

namespace UniversityScheduling.GeneticAlgorithm.Interfaces
{
    public interface IRandomSlotsGenerator
    {
        List<Slot> GetRandomSlots();
    }
}
