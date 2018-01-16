using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UniversityScheduling.Core;
using UniversityScheduling.Core.Interfaces;
using UniversityScheduling.GeneticAlgorithm.Interfaces;

namespace UniversityScheduling.GeneticAlgorithm
{
    public class ScheduleCrossover : ICrossover
    {
        private readonly ISubjectsRepository _subjectsRepository;

        public ScheduleCrossover(ISubjectsRepository subjectsRepository)
        {
            _subjectsRepository = subjectsRepository;
        }

        public ScheduleDNA Crossover(ScheduleDNA firstParent, ScheduleDNA secondParent)
        {
            return null;
        }
    }
}
