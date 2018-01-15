using System;
using System.Collections.Generic;
using System.Text;
using UniversityScheduling.Core;
using UniversityScheduling.GeneticAlgorithm.Interfaces;

namespace UniversityScheduling.GeneticAlgorithm
{
    public class ScheduleDNA
    {
        public List<Slot> Genes { get; private set; }
        public float Fitness { get; private set; }

        private readonly IRandomSlotsGenerator _slotsGenerator;
        private readonly IFitnessCalculator _fitnessCalculator;
        private readonly Random _random;
        private readonly int _slotsCount;

        public ScheduleDNA(IRandomSlotsGenerator slotsGenerator, IFitnessCalculator fitnessCalculator, Random random, bool shouldInitGenes = true, int slotsCount = 80)
        {
            _slotsGenerator = slotsGenerator;
            _fitnessCalculator = fitnessCalculator;
            _random = random;
            _slotsCount = slotsCount;
            Genes = shouldInitGenes ? _slotsGenerator.GetRandomSlots() : new List<Slot>(slotsCount);
                
        }

        public float CalculateFitness()
        {
            Fitness = _fitnessCalculator.CalculateFitness(Genes);
            return Fitness;
        }

        public ScheduleDNA Crossover(ScheduleDNA otherParent)
        {
            ScheduleDNA child = MidPointCrossover(otherParent);
            return child;
        }

        public void Mutate(float mutationRate)
        {
            for (int i = 0; i < Genes.Count; i++)
            {
                if (_random.NextDouble() < mutationRate)
                {
                    //Genes[i] = ?? New gene
                }
            }
        }

        private ScheduleDNA MidPointCrossover(ScheduleDNA otherParent)
        {
            ScheduleDNA child = new ScheduleDNA(_slotsGenerator, _fitnessCalculator, _random, shouldInitGenes: false);

            double randomNumber = 0.2; //_random.NextDouble();

            int slotsCountInDay = _slotsCount / 5;

            //Get Monday and Tuesday slots from first parent and get Wedensday, Thursday and Friday slots from second parent.
            if (randomNumber < 0.5)
            {
                for (int i = 0; i < slotsCountInDay * 2; i++)
                {
                    child.Genes.Add(Genes[i]);
                }

                for (int i = slotsCountInDay * 2; i < _slotsCount; i++)
                {
                    child.Genes.Add(otherParent.Genes[i]);
                }
            }

            return child;
        }
    }
}
