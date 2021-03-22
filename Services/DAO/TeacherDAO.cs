using Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Services.DAO
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
            context.Remove(context.Teachers.Where(t => t.TeacherId == teacherId).FirstOrDefault());
            return this.context.SaveChanges();
        }
        public Teachers GetTeacherByUserID(int userID)
        {
            return this.context.Teachers
                .FirstOrDefault(t => t.UserId == userID);
        }
        public ICollection<Subjects> GetTeacherSubjects(int teacherId)
        {
            return this.context.Teachers
                .Include(t => t.Subjects)
                .FirstOrDefault(t => t.TeacherId == teacherId)
                .Subjects;
        }
        public Teachers GetTeacherById(int teacherId)
        {
            return this.context.Teachers
                .Include(t => t.Subjects)
                .FirstOrDefault(t => t.TeacherId == teacherId);
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
