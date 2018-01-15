using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UniversityScheduling.Core;
using UniversityScheduling.Core.Enums;
using UniversityScheduling.Core.Interfaces;

namespace UniversityScheduling.GeneticAlgorithm.FakeRepositories
{
    public class SubjectsFakeRepository : ISubjectsRepository
    {
        private readonly List<Subject> _subjects = new List<Subject>()
        {
            new Subject()
            {
                Id = 1,
                Name = "MPT",
                Duration = 2,
                InstructorId = 1,
                Type = SubjectType.Lecture                
            },
            new Subject()
            {
                Id = 2,
                Name = "MPT",
                Duration = 2,
                InstructorId = 1,
                Type = SubjectType.Laboratory
            },
            new Subject()
            {
                Id = 3,
                Name = "PI",
                Duration = 2,
                InstructorId = 2,
                Type = SubjectType.Lecture
            },
            new Subject()
            {
                Id = 4,
                Name = "PI",
                Duration = 2,
                InstructorId = 2,
                Type = SubjectType.Exercise
            },
            new Subject()
            {
                Id = 5,
                Name = "ED",
                Duration = 4,
                InstructorId = 3,
                Type = SubjectType.Laboratory
            },
            new Subject()
            {
                Id = 6,
                Name = "MwPSiS",
                Duration = 2,
                InstructorId = 4,
                Type = SubjectType.Lecture
            },
            new Subject()
            {
                Id = 7,
                Name = "MwPSiS",
                Duration = 2,
                InstructorId = 5,
                Type = SubjectType.Laboratory
            },
            new Subject()
            {
                Id = 8,
                Name = "ZSTwP",
                Duration = 2,
                InstructorId = 6,
                Type = SubjectType.Lecture
            },
            new Subject()
            {
                Id = 9,
                Name = "SSP",
                Duration = 2,
                InstructorId = 7,
                Type = SubjectType.Lecture
            },
            new Subject()
            {
                Id = 10,
                Name = "SSP",
                Duration = 2,
                InstructorId = 7,
                Type = SubjectType.Laboratory
            },
            new Subject()
            {
                Id = 11,
                Name = "KRO",
                Duration = 2,
                InstructorId = 8,
                Type = SubjectType.Lecture
            },
            new Subject()
            {
                Id = 12,
                Name = "KRO",
                Duration = 2,
                InstructorId = 8,
                Type = SubjectType.Laboratory
            },
            new Subject()
            {
                Id = 13,
                Name = "AEN",
                Duration = 2,
                InstructorId = 9,
                Type = SubjectType.Lecture
            },
            new Subject()
            {
                Id = 14,
                Name = "AEN",
                Duration = 2,
                InstructorId = 9,
                Type = SubjectType.Exercise
            },
            new Subject()
            {
                Id = 15,
                Name = "RZwSIP",
                Duration = 2,
                InstructorId = 10,
                Type = SubjectType.Lecture
            },
            new Subject()
            {
                Id = 16,
                Name = "RZwSIP",
                Duration = 4,
                InstructorId = 10,
                Type = SubjectType.Laboratory
            }
        };

        public int Count => _subjects.Count;

        public Subject GetById(int id)
        {
            return _subjects.Single(x => x.Id == id);
        }
    }
}
