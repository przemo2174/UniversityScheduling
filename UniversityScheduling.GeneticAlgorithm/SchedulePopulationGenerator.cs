using System;
using System.Collections.Generic;
using System.Text;
using UniversityScheduling.GeneticAlgorithm.Interfaces;

namespace UniversityScheduling.GeneticAlgorithm
{
    public class SchedulePopulationGenerator : ISchedulePopulationGenerator
    {
        private List<ScheduleDNA> _population;
        private readonly IRandomSlotsGenerator _slotsGenerator;
        private readonly Random _random;
        private readonly IFitnessCalculator _fitnessCalculator;

        public SchedulePopulationGenerator(IRandomSlotsGenerator slotsGenerator, IFitnessCalculator fitnessCalculator, Random random)
        {
            _slotsGenerator = slotsGenerator;
            _fitnessCalculator = fitnessCalculator;
            _random = random;
        }

        public List<ScheduleDNA> CreateScheduleDNAPopulation(int populationSize)
        {
            _population = new List<ScheduleDNA>(populationSize);
            for (int i = 0; i < populationSize; i++)
            {
                _population.Add(new ScheduleDNA(_slotsGenerator, _fitnessCalculator, _random));
            }

            return _population;
        }
    }
}
