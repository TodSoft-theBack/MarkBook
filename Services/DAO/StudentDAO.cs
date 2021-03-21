using System;
using System.Collections.Generic;
using System.Text;
using Services.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Services;

namespace Services.DAO
{
    public class StudentDAO
    {
        private MarkBookDBContext context { get; set; }
        public int AddStudent(string firstName, string lastName, int userId, int gradeId)
        {
            Students student = new Students();
            student.FirstName = firstName;
            student.LastName = lastName;
            student.UserID = userId;
            student.GradeID = gradeId;

            this.context.Students.Add(student);
            return this.context.SaveChanges();
        }
        public Students GetStudentById(int id)
        {
            return context.Students.Where(st => st.StudentID == id).FirstOrDefault();
        }
        public int RemoveStudentById(int id)
        {
            int userNum = context.Students.Where(t => t.StudentID == id).FirstOrDefault().UserID;
            context.Remove(context.Students.Where(t => t.StudentID == id).FirstOrDefault());
            context.Remove(context.Users.Where(u => u.UserID == userNum).FirstOrDefault());
            return this.context.SaveChanges();
        }
        public List<Students> AllStudentsFromGrade(int gradeId)
        {
            var students = this.context.Students
                .Where(st => st.GradeID.Equals(gradeId))
                .ToList();

            return students;
        }
        public Students GetStudentByUserID(int userID)
        {
            return this.context.Students.Where(st => st.UserID == userID).FirstOrDefault();
        }
        public List<Marks> AllMarksOfStudent(int studentId)
        {
            List <Marks> marks = context.Marks.Where(m => m.StudentID == studentId).ToList();
            return marks;
        }       
        public StudentDAO(MarkBookDBContext context)
        {
            if (context == null) throw new ArgumentNullException("context");
            this.context = context;
        }
    }
}
