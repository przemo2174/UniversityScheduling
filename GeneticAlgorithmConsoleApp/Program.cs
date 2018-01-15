using System;
using UniversityScheduling.Core.Repositories;
using UniversityScheduling.GeneticAlgorithm;
using UniversityScheduling.GeneticAlgorithm.FakeRepositories;

namespace GeneticAlgorithmConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            SchedulingGeneticAlgorithm schedulingAlgorithm = new SchedulingGeneticAlgorithm(
                new SchedulePopulationGenerator(
                    new RandomSlotsGenerator(
                        new RoomsRandomizer(new RoomsFakeRepository()),
                        new SubjectsFakeRepository(),
                        new InstructorsFakeRepository()),
                    new FitnessCalculator(new RoomsFakeRepository(), new SubjectsFakeRepository(),
                        new SubjectsFakeRepository().Count),
                    new Random()),
                100, new Random());

            while (schedulingAlgorithm.BestFitness < 0.9)
            {
                Console.WriteLine("Generation: {0}", schedulingAlgorithm.Generation);
                Console.WriteLine("Best Fitness: {0}", schedulingAlgorithm.BestFitness);
                schedulingAlgorithm.NewGeneration();
            }
        }
    }
}
