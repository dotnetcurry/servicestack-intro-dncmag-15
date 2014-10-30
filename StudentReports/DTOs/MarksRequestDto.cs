using ServiceStack;
using StudentReports.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentReports.DTOs
{
    [Route("/marks/student/{StudentId}", Verbs = "GET")]
    [Route("/marks/{MarksId}", Verbs = "GET, PUT")]
    [Route("/marks", Verbs = "POST")]
    public class MarksRequestDto
    {
        public int MarksId { get; set; }
        public int StudentId { get; set; }
        public int MarksAwarded { get; set; }
        public int MaxMarks { get; set; }
        public string Subject { get; set; }
    }

    //[Route("/marks/{Id}", Verbs = "PUT")]
    //public class MarksPutDto
    //{
    //    public int Id { get; set; }
    //    public int StudentId { get; set; }
    //    public int MarksAwarded { get; set; }
    //    public int MaxMarks { get; set; }
    //    public string Subject { get; set; }
    //}

    public class MarksGetResponseDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Class { get; set; }
        public IEnumerable<Marks> Marks { get; set; }
    }
}