﻿using Services.Models;
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
            if (firstName == null)
            {
                throw new ArgumentException("A valid first name is required");
            }

            if (lastName == null)
            {
                throw new ArgumentException("A valid last name is required");
            }

            if (userId == 0)
            {
                throw new ArgumentException("A user's id is required");
            }

            var user = this.context.Users.Where(u => u.UserId == userId).FirstOrDefault();

            if (user == null)
            {
                throw new ArgumentException("This user does not exist");
            }

            if (gradeId == 0)
            {
                throw new ArgumentException("A grade is required");
            }

            var grade = this.context.Grades.Where(g => g.GradeId == gradeId).FirstOrDefault();

            if (grade == null)
            {
                throw new ArgumentException("This grade does not exist");
            }

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
            if (id == 0)
            {
                throw new ArgumentException("A valid student id is required");
            }

            return context.Students
                .Include(s => s.Marks)
                .Where(st => st.StudentId == id)
                .FirstOrDefault();
        }
        public int RemoveStudentById(int id)
        {
            if (id == 0)
            {
                throw new ArgumentException("A valid id is required");
            }

            int? userNum = context.Students.Where(t => t.StudentId == id).FirstOrDefault().UserId;
            context.Remove(context.Students.Where(t => t.StudentId == id).FirstOrDefault());
            context.Remove(context.Users.Where(u => u.UserId == userNum).FirstOrDefault());
            return this.context.SaveChanges();
        }
        public List<Students> AllStudentsFromGrade(int gradeId)
        {
            if (gradeId == 0)
            {
                throw new ArgumentException("A valid id is required");
            }

            var students = this.context.Students
                .Include(s => s.Marks)
                .Where(st => st.GradeId.Equals(gradeId))
                .ToList();

            return students;
        }
        public Students GetStudentByUserID(int userID)
        {
            if (userID == 0)
            {
                throw new ArgumentException("A valid id is required");
            }

            return this.context.Students
                .Include(s => s.User)
                .Where(st => st.UserId == userID)
                .FirstOrDefault();
        }
        public List<Marks> AllMarksOfStudent(int studentId)
        {
            if (studentId == 0)
            {
                throw new ArgumentException("A valid student id is required");
            }
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
