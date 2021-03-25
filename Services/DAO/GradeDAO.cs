using Services.Models;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Services.DAO
{
    public partial class GradeDAO
    {
        public Grades GetGrade(int gradeId)
        {
            if (gradeId == 0)
            {
                throw new ArgumentException("Invalid grade id");
            }

            var grade = this.context.Grades.Where(g => g.GradeId == gradeId).FirstOrDefault();
            if (grade == null)
            {
                throw new ArgumentException("This grade does not exist");
            }

            return this.context.Grades
                .Include(g => g.Subjects)
                .ThenInclude(s => s.Marks)
                .Where(g => g.GradeId == gradeId)
                .FirstOrDefault();
        }

        public int AddGrade(int gradeNumber, string gradeForm)
        {
            if (gradeNumber < 1 || gradeNumber > 12)
            {
                throw new ArgumentException("Invalid number for a grade, grades can only have a number between 1 and 12");
            }

            if (string.IsNullOrWhiteSpace(gradeForm))
            {
                throw new ArgumentException("Invalid grade form");
            }

            if (this.context.Grades.Contains(this.context.Grades.Where(g => g.GradeNumber == gradeNumber && g.GradeForm == gradeForm).FirstOrDefault()))
            {
                throw new ArgumentException("This grade already exists");
            }

            var grade = new Grades();
            grade.GradeNumber = gradeNumber;
            grade.GradeForm = gradeForm;
            context.Grades.Add(grade);
            return context.SaveChanges();
        }

        public ICollection<Students> GetStudentsByGradeId(int gradeId)
        {
            if (gradeId == 0)
            {
                throw new ArgumentException("Invalid grade id");
            }

            var grade = this.context.Grades.Where(g => g.GradeId == gradeId).FirstOrDefault();
            if (grade == null)
            {
                throw new ArgumentException("Invalid grade");
            }

            return this.context.Grades
                .Include(g => g.Students)
                .FirstOrDefault(g => g.GradeId == gradeId).Students;
        }

        private MarkBookDBContext context;
        public GradeDAO(MarkBookDBContext context)
        {
            if (context == null) throw new ArgumentNullException("context");

            this.context = context;
        }

    }
}
