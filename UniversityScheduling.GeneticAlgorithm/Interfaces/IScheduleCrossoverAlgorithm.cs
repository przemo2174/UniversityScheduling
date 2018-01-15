using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityScheduling.GeneticAlgorithm.Interfaces
{
    public interface IScheduleCrossoverAlgorithm
    {
        ScheduleDNA Crossover(ScheduleDNA firstParent);
    }
}
