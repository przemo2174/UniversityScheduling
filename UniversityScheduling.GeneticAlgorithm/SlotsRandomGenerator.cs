using System;
using System.Collections.Generic;
using System.Text;
using UniversityScheduling.Core;
using UniversityScheduling.GeneticAlgorithm.Interfaces;

namespace UniversityScheduling.GeneticAlgorithm
{
    public class SlotsRandomGenerator : IRandomSlotsGenerator
    {
        private List<int> RoomsIds;
        private List<int> SubjectIds;
        public SlotsRandomGenerator()
        {
                
        }
        public List<Slot> GetRandomSlots()
        {
            return null;
        }
    }
}
