using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityScheduling.GeneticAlgorithm.Interfaces
{
    public interface ISchedulePopulationGenerator
    {
        List<ScheduleDNA> CreateScheduleDNAPopulation(int populationSize);
    }
}
