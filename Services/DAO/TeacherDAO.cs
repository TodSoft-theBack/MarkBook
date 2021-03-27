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
            if (string.IsNullOrWhiteSpace(firstName))
            {
                throw new ArgumentException("A first name is required");
            }

            if (string.IsNullOrWhiteSpace(lastName))
            {
                throw new ArgumentException("A last name is required");
            }

            if (userId == 0)
            {
                throw new ArgumentException("A valid user id is required");
            }

            var user = this.context.Users.Where(u => u.UserId == userId).FirstOrDefault();
            if (user == null)
            {
                throw new ArgumentException("This user does not exist");
            }

            if (this.context.Teachers.Contains(this.context.Teachers.Where(t => t.UserId == userId).FirstOrDefault()))
            {
                throw new ArgumentException("This teacher already exists");
            }

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
            if (teacherId == 0)
            {
                throw new ArgumentException("This teacher does not exist");
            }

            var teacher = this.context.Teachers.Where(t => t.TeacherId == teacherId).FirstOrDefault();
            if (teacher == null)
            {
                throw new ArgumentException("This teacher does not exist");
            }

            context.Remove(context.Teachers.Where(t => t.TeacherId == teacherId).FirstOrDefault());
            return this.context.SaveChanges();
        }
        public Teachers GetTeacherByUserID(int userID)
        {
            if (userID <= 0)
            {
                throw new ArgumentException("Id must be greater than 0");
            }

            return this.context.Teachers
                .FirstOrDefault(t => t.UserId == userID);
        }
        public ICollection<Subjects> GetTeacherSubjects(int teacherId)
        {
            if (teacherId == 0)
            {
                throw new ArgumentException("This teacher does not exist");
            }

            var teacher = this.context.Teachers.Where(t => t.TeacherId == teacherId).FirstOrDefault();
            if (teacher == null)
            {
                throw new ArgumentException("This teacher does not exist");
            }

            return this.context.Teachers
                .Include(t => t.Subjects)
                .ThenInclude(t => t.Grade)
                .FirstOrDefault(t => t.TeacherId == teacherId)
                .Subjects;
        }
        public Teachers GetTeacherById(int teacherId)
        {
            if (teacherId <= 0)
            {
                throw new ArgumentException("Id must be greater than 0");
            }

            var teacher = this.context.Teachers.Where(t => t.TeacherId == teacherId).FirstOrDefault();
            return this.context.Teachers
                .Include(t => t.Subjects)
                .FirstOrDefault(t => t.TeacherId == teacherId);
        }
        public ICollection<Subjects> GetSubjectsByTeacherId(int teacherId)
        {
            if (teacherId == 0)
            {
                throw new ArgumentException("This teacher does not exist");
            }

            var teacher = this.context.Teachers.Where(t => t.TeacherId == teacherId).FirstOrDefault();
            if (teacher == null)
            {
                throw new ArgumentException("This teacher does not exist");
            }

            return context.Teachers.FirstOrDefault(x => x.TeacherId == teacherId)?.Subjects;
        }

        private MarkBookDBContext context;
        public TeacherDAO(MarkBookDBContext context)
        {
            if (context == null) throw new ArgumentNullException("context");

            this.context = context;
        }
    }
}
