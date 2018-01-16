using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityScheduling.GeneticAlgorithm.Interfaces
{
    public interface ICrossover
    {
        ScheduleDNA Crossover(ScheduleDNA firstParent, ScheduleDNA secondParent);
    }
}
