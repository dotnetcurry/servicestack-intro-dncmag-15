using ServiceStack.Data;
using ServiceStack.OrmLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentReports.Models
{
    public class DbInitializer
    {
        public static void InitializeDb(IDbConnectionFactory dbConnectionFactory)
        {
            var students = new List<Student>()
            {
                new Student(){Name="Andrew",City="Boston",CurrentClass=2},
                new Student(){Name="Richa",City="Chicago",CurrentClass=3},
                new Student(){Name="Dave",City="Phoenix",CurrentClass=4},
                new Student(){Name="Ema",City="Washington",CurrentClass=5},
                new Student(){Name="Filip",City="Texas",CurrentClass=6},
                new Student(){Name="Maggi",City="Los Angeles",CurrentClass=7},
                new Student(){Name="Nathan",City="Atlanta",CurrentClass=8}
            };

            var studentMarks = new List<Marks>()
            {
                new Marks(){Subject="Mathematics",MarksAwarded=80,MaxMarks=100, StudentId=1},
                new Marks(){Subject="English",MarksAwarded=70,MaxMarks=100, StudentId=1},
                new Marks(){Subject="Hindi",MarksAwarded=75,MaxMarks=100, StudentId=1},
                new Marks(){Subject="Mathematics",MarksAwarded=60,MaxMarks=100, StudentId=2},
                new Marks(){Subject="English",MarksAwarded=90,MaxMarks=100, StudentId=3},
                new Marks(){Subject="Hindi",MarksAwarded=85,MaxMarks=100, StudentId=2},
                new Marks(){Subject="Mathematics",MarksAwarded=90,MaxMarks=100, StudentId=2},
                new Marks(){Subject="English",MarksAwarded=80,MaxMarks=100, StudentId=3},
                new Marks(){Subject="Hindi",MarksAwarded=80,MaxMarks=100, StudentId=3}
            };

            using (var db = dbConnectionFactory.OpenDbConnection())
            {

                if (!db.TableExists("Student"))
                {
                    db.CreateTable<Student>();
                    db.InsertAll<Student>(students);
                }

                if (!db.TableExists("Marks"))
                {
                    db.CreateTable<Marks>();
                    db.InsertAll<Marks>(studentMarks);
                }

            }
        }
    }
}