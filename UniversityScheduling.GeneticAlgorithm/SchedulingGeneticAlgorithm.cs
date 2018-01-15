using System;
using System.Collections.Generic;
using System.Text;
using UniversityScheduling.Core;
using UniversityScheduling.GeneticAlgorithm.Interfaces;

namespace UniversityScheduling.GeneticAlgorithm
{
    public class SchedulingGeneticAlgorithm
    {
        public List<ScheduleDNA> Population { get; private set; }
        public int Generation { get; private set; }       
        public float MutationRate { get; private set; }
        public float BestFitness { get; private set; }
        public List<Slot> BestGenes { get; private set; }

        private readonly ISchedulePopulationGenerator _schedulePopulationGenerator;
        private readonly Random _random;
        private float _fitnessSum;

        public SchedulingGeneticAlgorithm(ISchedulePopulationGenerator schedulePopulationGenerator, int populationSize, Random random, float mutationRate = 0.01f)
        {
            Generation = 1;
            MutationRate = mutationRate;
            _schedulePopulationGenerator = schedulePopulationGenerator;
            Population = _schedulePopulationGenerator.CreateScheduleDNAPopulation(populationSize);
            _random = random;
        }

        public void NewGeneration()
        {
            if (Population.Count <= 0)
            {
                return;
            }
            
            CalculateFitness();

            List<ScheduleDNA> newPopulation = new List<ScheduleDNA>();
            for (int i = 0; i < Population.Count; i++)
            {
                ScheduleDNA parent1 = ChooseParent();
                ScheduleDNA parent2 = ChooseParent();

                ScheduleDNA child = parent1.Crossover(parent2);

                newPopulation.Add(child);
            }

            Population = newPopulation;
            Generation++;
        }

        public void CalculateFitness()
        {
            _fitnessSum = 0;
            ScheduleDNA best = Population[0];

            for (int i = 0; i < Population.Count; i++)
            {
                _fitnessSum += Population[i].CalculateFitness();
                if (Population[i].Fitness > best.Fitness)
                {
                    best = Population[i];
                }

                BestFitness = best.Fitness;
                BestGenes = new List<Slot>(best.Genes);
            }
        }

        private ScheduleDNA ChooseParent()
        {
            double randomNumber = _random.NextDouble() * _fitnessSum;
            //float partialSum = 0.0f;
            for (int i = 0; i < Population.Count; i++)
            {
                //partialSum += Population[i].Fitness;
                //if (randomNumber < partialSum)
                //{
                //    return Population[i];
                //}

                if (randomNumber < Population[i].Fitness)
                {
                    return Population[i];
                }

                randomNumber -= Population[i].Fitness;
            }

            return null;
        }
    }
}
