using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UniversityScheduling.Core;
using UniversityScheduling.Core.Interfaces;
using UniversityScheduling.GeneticAlgorithm.Interfaces;

namespace UniversityScheduling.GeneticAlgorithm
{
    public class FitnessCalculator : IFitnessCalculator
    {
        private readonly IRoomsRepository _roomsRepository;
        private readonly ISubjectsRepository _subjectsRepository;
        private readonly int _maxScore;
        public FitnessCalculator(IRoomsRepository roomsRepository, ISubjectsRepository subjectsRepository, int maxScore)
        {
            _roomsRepository = roomsRepository;
            _subjectsRepository = subjectsRepository;
            _maxScore = maxScore;
        }

        public float CalculateFitness(List<Slot> genes)
        {
            float score = 0.0f;

            List<IGrouping<int, Slot>> slotsGroupedBySubject =
                genes.Where(x => x.SubjectId != -1).GroupBy(x => x.SubjectId).ToList();

            foreach (IGrouping<int, Slot> group in slotsGroupedBySubject)
            {                
                Slot subjectSlot = group.First();

                Subject subject = _subjectsRepository.GetById(subjectSlot.SubjectId);
                Room room = _roomsRepository.GetById(subjectSlot.RoomId);

                //check if room is good for subject
                if (subject.Type == room.Type)
                {
                    score++;
                }
            }

            return score / _maxScore;
        }
    }
}
