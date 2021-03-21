using System;
using System.Collections.Generic;
using System.Linq;

namespace Services.Models
{
    public partial class TeacherDAO
    {
        public int AddTeacher(string firstName, string lastName, int userId)
        {
            Teachers Teacher = new Teachers
            {
                FirstName = firstName,
                LastName = lastName,
                UserId = userId
            };

            this.context.Teachers.Add(Teacher);
            return this.context.SaveChanges();
        }
        public int RemoveTeacherById(int teacherId)
        {

            // int userNum = context.Teachers.Where(t => t.TeacherID == teacherId).FirstOrDefault().UserID;
            context.Remove(context.Teachers.Where(t => t.TeacherId == teacherId).FirstOrDefault());
            // context.Remove(context.Users.Where(u => u.UserID == userNum).FirstOrDefault());
            return this.context.SaveChanges();
        }
        public Teachers GetTeacherByUserID(int userID)
        {
            return this.context.Teachers.FirstOrDefault(t => t.UserId == userID);
        }
        public Teachers GetTeacherById(int teacherId)
        {
            return this.context.Teachers.FirstOrDefault(t => t.TeacherId.Equals(teacherId));
        }
        public ICollection<Subjects> GetSubjectsByTeacherId(int teacherID)
        {
            return context.Teachers.FirstOrDefault(x => x.TeacherId == teacherID)?.Subjects;
        }

        private MarkBookDBContext context;
        public TeacherDAO(MarkBookDBContext context)
        {
            if (context == null) throw new ArgumentNullException("context");

            this.context = context;
        }
    }
}
