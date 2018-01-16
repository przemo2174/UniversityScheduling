using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UniversityScheduling.Core.Helpers;
using UniversityScheduling.Core.Repositories;
using UniversityScheduling.GeneticAlgorithm;
using UniversityScheduling.GeneticAlgorithm.FakeRepositories;
using UniversityScheduling.GeneticAlgorithm.Interfaces;

namespace UniversityScheduling.Core.Tests
{
    [TestClass]
    public class SlotGeneratorTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            SlotsGenerator generator = new SlotsGenerator(TimeSpan.FromMinutes(50));

            var slots = generator.GetSlots();
        }

        [TestMethod]
        public void FillWithSubjectsSlotsTest()
        {
            RandomSlotsGenerator generator = new RandomSlotsGenerator(new RoomsRandomizer(new RoomsFakeRepository()), new SubjectsFakeRepository(), new InstructorsFakeRepository());
            var slots = generator.GetRandomFilledSlots();
            var slotsWithSubjects = slots.Where(x => x.SubjectId != -1);
        }

        [TestMethod]
        public void MidpointCrossoverTest()
        {
            IRandomSlotsGenerator randomSlotsGenerator1 = new RandomSlotsGenerator(new RoomsRandomizer(new RoomsFakeRepository()), new SubjectsFakeRepository(), new InstructorsFakeRepository());
            IRandomSlotsGenerator randomSlotsGenerator2 = new RandomSlotsGenerator(new RoomsRandomizer(new RoomsFakeRepository()), new SubjectsFakeRepository(), new InstructorsFakeRepository());
            Random random = new Random();
            IFitnessCalculator fitnessCalculator = new FitnessCalculator(new RoomsFakeRepository(), new SubjectsFakeRepository(), new SubjectsFakeRepository().Count);

            ScheduleDNA firstSchedule = new ScheduleDNA(randomSlotsGenerator1, fitnessCalculator, random);
            ScheduleDNA secondSchedule = new ScheduleDNA(randomSlotsGenerator2, fitnessCalculator, random);

            ScheduleDNA child = firstSchedule.Crossover(secondSchedule);
          
            float fitness1 = fitnessCalculator.CalculateFitness(firstSchedule.Genes);
            float fitness2 = fitnessCalculator.CalculateFitness(secondSchedule.Genes);
            float fitness3 = fitnessCalculator.CalculateFitness(child.Genes);
        }
    }
}
