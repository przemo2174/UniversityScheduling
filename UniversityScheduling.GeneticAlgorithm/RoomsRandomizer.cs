using System;
using System.Collections.Generic;
using System.Text;
using UniversityScheduling.Core;
using UniversityScheduling.Core.Interfaces;
using UniversityScheduling.GeneticAlgorithm.Interfaces;

namespace UniversityScheduling.GeneticAlgorithm
{
    public class RoomsRandomizer : IRoomsRandomizer
    {
        private readonly IRoomsRepository _roomsRepository;
        private readonly Random _random;

        public RoomsRandomizer(IRoomsRepository rooms)
        {
            _roomsRepository = rooms;
            _random = new Random();
        }

        public Room GetRandomRoom()
        {
            int randomId = _random.Next(1, _roomsRepository.Count + 1);
            return _roomsRepository.GetById(randomId);
        }
    }
}
