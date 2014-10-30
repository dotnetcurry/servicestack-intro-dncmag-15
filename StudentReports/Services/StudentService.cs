using ServiceStack;
using ServiceStack.Web;
using StudentReports.DTOs;
using StudentReports.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;

namespace StudentReports.Services
{
    public class StudentService : Service
    {
        StudentDbRepository repository;

        public StudentService(StudentDbRepository _repository)
        {
            repository = _repository;
        }

        public IHttpResult Get(StudentRequestDto studentDto)
        {
            if (studentDto.Id == default(int))
            {
                var result = new HttpResult(repository.GetStudents());
                return result;
            }
            else
            {
                var student = repository.GetStudentById(studentDto.Id);

                if (student != null)
                {
                    return new HttpResult(student);
                }
                else
                {
                    return new HttpError(HttpStatusCode.NotFound,"Student with id "+studentDto.Id + " doesn't exist.");
                }
            }
        }
    }    

}