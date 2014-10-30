using ServiceStack.Data;
using ServiceStack.OrmLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentReports.Models
{
    public class StudentDbRepository
    {
        public IDbConnectionFactory DbConnectionFactory { get; set; }

        public List<Student> GetStudents()
        {
            using (var db = DbConnectionFactory.OpenDbConnection())
            {
                return db.Select<Student>();
            }
        }

        public Student GetStudentById(int studentId)
        {
            using (var db = DbConnectionFactory.OpenDbConnection())
            {
                return db.Select<Student>(s => s.StudentId == studentId).FirstOrDefault();
            }
        }

        public List<Marks> GetMarksByStudent(int studentId)
        {
            using (var db = DbConnectionFactory.OpenDbConnection())
            {
                return db.Select<Marks>(m => m.StudentId == studentId);
            }
        }

        public Marks GetMarks(int marksId)
        {
            using (var db = DbConnectionFactory.OpenDbConnection())
            {
                return db.Select<Marks>(m => m.Id == marksId).FirstOrDefault();
            }
        }

        public int AddMarks(Marks marks)
        {
            using (var db = DbConnectionFactory.OpenDbConnection())
            {
                db.Insert(marks);
                return (int)db.LastInsertId();
            }
        }

        public int UpdateMarks(Marks marks)
        {
            using (var db = DbConnectionFactory.OpenDbConnection())
            {
                return db.Update(marks);
            }
        }
    }
}