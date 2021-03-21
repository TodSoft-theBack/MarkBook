using Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Services.DAO
{
    public class TeacherDAO
    {

        public int AddTeacher(string firstName, string lastName, int userId)
        {
            Teachers Teacher = new Teachers();
            Teacher.FirstName = firstName;
            Teacher.LastName = lastName;
            Teacher.UserID = userId;

            this.context.Teachers.Add(Teacher);
            return this.context.SaveChanges();
        }

        public int RemoveTeacherById(int teacherId)
        {

           // int userNum = context.Teachers.Where(t => t.TeacherID == teacherId).FirstOrDefault().UserID;
            context.Remove(context.Teachers.Where(t => t.TeacherID == teacherId).FirstOrDefault());
           // context.Remove(context.Users.Where(u => u.UserID == userNum).FirstOrDefault());
            return this.context.SaveChanges();
        }

        public Teachers GetStudentByUserID(int userID)
        {
            return this.context.Teachers.FirstOrDefault(t => t.UserID == userID);
        }

        public Teachers GetTeacherById(int teacherId)
        {
            return this.context.Teachers.FirstOrDefault(t => t.TeacherID.Equals(teacherId));
        }

        public ICollection<Subjects> GetSubjectsByTeacherId(int teacherID)
        {
            return context.Teachers.FirstOrDefault(x => x.TeacherID == teacherID)?.Subjects;
        }

        private MarkBookDBContext context;
        public TeacherDAO(MarkBookDBContext context)
        {
            if (context == null) throw new ArgumentNullException("context");

            this.context = context;
        }
    }
}