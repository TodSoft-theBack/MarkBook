using System;
using System.Collections.Generic;
using System.Linq;

namespace Services.Models
{
    public partial class GradeDAO
    {
        public Grades GetGrade(int gradeId)
        {
            return this.context.Grades
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
        private MarkBookDBContext context;
        public GradeDAO(MarkBookDBContext context)
        {
            if (context == null) throw new ArgumentNullException("context");

            this.context = context;
        }

    }
}
