using ServiceStack;
using StudentReports.DTOs;
using StudentReports.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentReports.Services
{
    public class MarksService : Service
    {
        StudentDbRepository repository;

        public MarksService(StudentDbRepository _repository)
        {
            repository = _repository;
        }

        public object Get(MarksRequestDto dto)
        {
            if (dto.StudentId != default(int))
            {
                var student = repository.GetStudentById(dto.StudentId);
                var marks = repository.GetMarksByStudent(dto.StudentId);

                return new MarksGetResponseDto()
                {
                    Id = student.StudentId,
                    Name = student.Name,
                    Class = student.CurrentClass,
                    Marks = marks
                };
            }
            else if (dto.MarksId != default(int))
            {
                var marks = repository.GetMarks(dto.MarksId);
                var student = repository.GetStudentById(marks.StudentId);
                return new MarksGetResponseDto()
                {
                    Id = student.StudentId,
                    Name = student.Name,
                    Class = student.CurrentClass,
                    Marks = new List<Marks>() { marks }
                };
            }
            return null;
        }

        public object Post(MarksRequestDto dto)
        {
            var nextId = StaticStudentDb.studentMarks[StaticStudentDb.studentMarks.Count() - 1].Id;
            var newStudentMarks = new Marks()
            {
                StudentId = dto.StudentId,
                MarksAwarded = dto.MarksAwarded,
                MaxMarks = dto.MaxMarks,
                Subject = dto.Subject
            };

            var id = repository.AddMarks(newStudentMarks);
            newStudentMarks.Id = id;

            return newStudentMarks;
        }

        public object Put(MarksRequestDto dto)
        {
            return repository.UpdateMarks(new Marks()
            {
                Id = dto.MarksId,
                Subject = dto.Subject,
                StudentId = dto.StudentId,
                MarksAwarded = dto.MarksAwarded,
                MaxMarks = dto.MaxMarks
            });
        }
    }
}