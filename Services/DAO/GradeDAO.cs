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
            return this.context.Grades
                .Include(g => g.Subjects)
                .ThenInclude(s => s.Marks)
                .Where(g => g.GradeId == gradeId)
                .FirstOrDefault();
        }
        public int AddGrade(int gradeNumber, string gradeForm)
        {
            var grade = new Grades();
            grade.GradeNumber = gradeNumber;
            grade.GradeForm = gradeForm;
            context.Grades.Add(grade);
            return context.SaveChanges();
        }
        public ICollection<Students> GetStudentsByGradeId(int gradeId)
        {
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
