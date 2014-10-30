using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentReports.Models
{
    public static class StaticStudentDb
    {
        public static List<Student> students;
        public static List<Marks> studentMarks;

        static StaticStudentDb()
        {
            students = new List<Student>()
            {
                new Student(){StudentId=1,Name="Andrew",City="Boston",CurrentClass=2},
                new Student(){StudentId=2,Name="Richa",City="Chicago",CurrentClass=3},
                new Student(){StudentId=3,Name="Dave",City="Phoenix",CurrentClass=4},
                new Student(){StudentId=4,Name="Ema",City="Washington",CurrentClass=5},
                new Student(){StudentId=5,Name="Filip",City="Texas",CurrentClass=6},
                new Student(){StudentId=6,Name="Maggi",City="Los Angeles",CurrentClass=7},
                new Student(){StudentId=7,Name="Nathan",City="Atlanta",CurrentClass=8}
            };

            studentMarks = new List<Marks>()
            {
                new Marks(){Id=1,Subject="Mathematics",MarksAwarded=80,MaxMarks=100, StudentId=1},
                new Marks(){Id=2,Subject="English",MarksAwarded=70,MaxMarks=100, StudentId=1},
                new Marks(){Id=3,Subject="Hindi",MarksAwarded=75,MaxMarks=100, StudentId=1},
                new Marks(){Id=4,Subject="Mathematics",MarksAwarded=60,MaxMarks=100, StudentId=2},
                new Marks(){Id=5,Subject="English",MarksAwarded=90,MaxMarks=100, StudentId=3},
                new Marks(){Id=6,Subject="Hindi",MarksAwarded=85,MaxMarks=100, StudentId=2},
                new Marks(){Id=7,Subject="Mathematics",MarksAwarded=90,MaxMarks=100, StudentId=2},
                new Marks(){Id=8,Subject="English",MarksAwarded=80,MaxMarks=100, StudentId=3},
                new Marks(){Id=9,Subject="Hindi",MarksAwarded=80,MaxMarks=100, StudentId=3}
            };
        }
    }
}