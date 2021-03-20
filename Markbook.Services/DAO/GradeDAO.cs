using System;
using System.Collections.Generic;
using System.Text;
using Markbook.Services.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Markbook.Services;


namespace Markbook.Services.DAO
{
    public class GradeDAO
    {
        public Grades GetGrade(int gradeId)
        {
            return this.context.Grades
                .Where(g => g.GradeID == gradeId)
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

        private MarkBookDBContext context;
        public GradeDAO(MarkBookDBContext context)
        {
            if (context == null) throw new ArgumentNullException("context");

            this.context = context;
        }

    }
}
