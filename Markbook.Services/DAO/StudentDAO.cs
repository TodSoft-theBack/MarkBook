﻿using System;
using System.Collections.Generic;
using System.Text;
using Markbook.Services.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Markbook.Services;
namespace Markbook.Services.DAO
{
    public class StudentDAO
    {
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

        public List<Marks> AllMarksOfStudent(int studentId)
        {
            List <Marks> marks = context.Marks.Where(m => m.StudentID == studentId).ToList();
            return marks;
        }

        private MarkBookDBContext context;
        public StudentDAO(MarkBookDBContext context)
        {
            if (context == null) throw new ArgumentNullException("context");

            this.context = context;
        }
    }
}
