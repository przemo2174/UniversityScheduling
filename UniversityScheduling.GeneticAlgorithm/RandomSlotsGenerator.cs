using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UniversityScheduling.Core;
using UniversityScheduling.Core.Enums;
using UniversityScheduling.Core.Interfaces;
using UniversityScheduling.GeneticAlgorithm.Interfaces;

namespace UniversityScheduling.GeneticAlgorithm
{
    public class RandomSlotsGenerator : IRandomSlotsGenerator
    {
        private readonly IRoomsRandomizer _roomsRandomizer;
        private readonly ISubjectsRepository _subjectsRepository;
        private readonly IInstructorsRepository _instructorsRepository;

        private readonly int _slotsCount;
        private List<Slot> _slots;
        private readonly Random _random = new Random();

        public RandomSlotsGenerator(IRoomsRandomizer roomsRandomizer, ISubjectsRepository subjects, IInstructorsRepository instructors, int slotsCount = 80)
        {
            _roomsRandomizer = roomsRandomizer;
            _subjectsRepository = subjects;
            _instructorsRepository = instructors;
            _slotsCount = slotsCount;
        }

        public List<Slot> GetInitializedSlots()
        {
            return InitializeSlots();
        }

        public List<Slot> GetRandomFilledSlots()
        {
            _slots = InitializeSlots();
            FillSlotsWithSubjects();
            AssingRoomsToSubjects();
            return _slots;
        }

        private List<Slot> InitializeSlots()
        {
            List<Slot> slots = new List<Slot>(_slotsCount);
            for (int i = 0; i < slots.Capacity; i++)
            {
                slots.Add(new Slot()
                {
                    Id = i + 1,
                    Number = i + 1,
                    SubjectId = -1,
                    RoomId = -1
                });              
            }

            return slots;
        }

        private void FillSlotsWithSubjects()
        {
            for (int i = 0; i < _subjectsRepository.Count; i++)
            {
                Subject subject = _subjectsRepository.GetById(i + 1);
                int slotId;
                do
                {
                    slotId = _random.Next(0, _slotsCount);
                } while (!CanSubjectBePlacedAtSlot(slotId, subject)); //if it is different it means that there is already some subject at this slot

                for(int j = slotId; j < slotId + subject.Duration; j++)
                    _slots[j].SubjectId = subject.Id;
            }
        }

        private bool CanSubjectBePlacedAtSlot(int slotId, Subject subject)
        {
            if (_slots[slotId].SubjectId != -1)
                return false;


            Day day = _slots[slotId].Day;
           
            for (int i = slotId; i < slotId + subject.Duration; i++)
            {
                if (i >= 80)
                    return false;
                if (_slots[i].SubjectId != -1 || _slots[i].Day != day) // Slots cannot be occupied and be on different days(must be contigious)
                    return false;
            }

            return true;
        }

        private void AssingRoomsToSubjects()
        {
            List<IGrouping<int, Slot>> slotsWithSubjects = _slots.Where(x => x.SubjectId != -1).GroupBy(x => x.SubjectId).ToList();
            foreach (IGrouping<int, Slot> slotsGroup in slotsWithSubjects)
            {
                Room randomRoom = _roomsRandomizer.GetRandomRoom();
                foreach (Slot slot in slotsGroup)
                {
                    slot.RoomId = randomRoom.Id;
                }
            }
        }
    }
}
