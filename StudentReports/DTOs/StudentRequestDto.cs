using ServiceStack;
using StudentReports.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentReports.DTOs
{
    [Route("/students", Verbs = "GET")] 
    [Route("/students/{id}", Verbs = "GET")]
    public class StudentRequestDto
    {
        public int Id { get; set; }
    }
}