using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UniversityScheduling.Core;
using UniversityScheduling.Core.Enums;
using UniversityScheduling.Core.Interfaces;

namespace UniversityScheduling.GeneticAlgorithm.FakeRepositories
{
    public class InstructorsFakeRepository : IInstructorsRepository
    {
        private readonly List<User> _instructors = new List<User>()
        {
            new User()
            {
                Id = 1,
                Name = "Piotr Borylo",
                UserType = UserType.Instructor
            },
            new User()
            {
                Id = 2,
                Name = "Michal Grega",
                UserType = UserType.Instructor
            },
            new User()
            {
                Id = 3,
                Name = "Lucjan Janowski",
                UserType = UserType.Instructor
            },
            new User()
            {
                Id = 4,
                Name = "Piotr Cholda",
                UserType = UserType.Instructor
            },
            new User()
            {
                Id = 5,
                Name = "Andrzej Kamisinski",
                UserType = UserType.Instructor
            },
            new User()
            {
                Id = 6,
                Name = "Wojciech Dziunikowski",
                UserType = UserType.Instructor
            },
            new User()
            {
                Id = 7,
                Name = "Grzegorz Rzym",
                UserType = UserType.Instructor
            },
            new User()
            {
                Id = 8,
                Name = "Jaroslaw Bialas",
                UserType = UserType.Instructor
            },
            new User()
            {
                Id = 9,
                Name = "Krzysztof Loziak",
                UserType = UserType.Instructor
            },
            new User()
            {
                Id = 10,
                Name = "Robert Chodorek",
                UserType = UserType.Instructor
            }       
        };

        public User GetById(int id)
        {
            return _instructors.Single(x => x.Id == id);
        }
    }
}
