using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentReports.Models
{
    public class Student
    {
        [AutoIncrement]
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public int CurrentClass { get; set; }
    }
}