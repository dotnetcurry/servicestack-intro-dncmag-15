using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentReports.Models
{
    public class Marks
    {
        [AutoIncrement]
        public int Id { get; set; }

        public int MarksAwarded { get; set; }
        public int MaxMarks { get; set; }
        public string Subject { get; set; }

        [References(typeof(Student))]
        public int StudentId { get; set; }
    }
}