using System.Collections.Generic;
using UniversityScheduling.Core;

namespace UniversityScheduling.GeneticAlgorithm.Interfaces
{
    public interface IFitnessCalculator
    {
        float CalculateFitness(List<Slot> genes);
    }
}
