using Services.Models;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;

namespace Services.DAO
{
    public class StudentDAO
    {
        private MarkBookDBContext context { get; set; }
        public int AddStudent(string firstName, string lastName, int userId, int gradeId)
        {
            Students student = new Students
            {
                FirstName = firstName,
                LastName = lastName,
                UserId = userId,
                GradeId = gradeId
            };
            this.context.Students.Add(student);
            return this.context.SaveChanges();
        }
        public Students GetStudentById(int id)
        {
            return context.Students
                .Include(s => s.Marks)
                .Where(st => st.StudentId == id)
                .FirstOrDefault();
        }
        public int RemoveStudentById(int id)
        {
            int? userNum = context.Students.Where(t => t.StudentId == id).FirstOrDefault().UserId;
            context.Remove(context.Students.Where(t => t.StudentId == id).FirstOrDefault());
            context.Remove(context.Users.Where(u => u.UserId == userNum).FirstOrDefault());
            return this.context.SaveChanges();
        }
        public List<Students> AllStudentsFromGrade(int gradeId)
        {
            var students = this.context.Students
                .Include(s => s.Marks)
                .Where(st => st.GradeId.Equals(gradeId))
                .ToList();

            return students;
        }
        public Students GetStudentByUserID(int userID)
        {
            return this.context.Students
                .Include(s => s.User)
                .Where(st => st.UserId == userID)
                .FirstOrDefault();
        }
        public List<Marks> AllMarksOfStudent(int studentId)
        {
            List<Marks> marks = context.Marks
                .Where(m => m.StudentId == studentId)
                .ToList();
            return marks;
        }
        public StudentDAO(MarkBookDBContext context)
        {
            if (context == null) throw new ArgumentNullException("context");
            this.context = context;
        }
    }
}
