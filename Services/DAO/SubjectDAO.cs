using Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Services.DAO
{
    public partial class SubjectDAO
    {
        public int AddSubject(string title, int teacherId)
        {
            if (string.IsNullOrWhiteSpace(title))
            {
                throw new ArgumentException("Invalid subject name");
            }

            if (teacherId == 0)
            {
                throw new ArgumentException("A valid teacher id is required");
            }

            var teacher = this.context.Teachers.Where(t => t.TeacherId == teacherId).FirstOrDefault();

            if (teacher == null)
            {
                throw new ArgumentException("This teacher does not exist");
            }

            if (this.context.Subjects.Contains(this.context.Subjects.Where(s => s.SubjectTitle == title && s.TeacherId == teacherId).FirstOrDefault()))
            {
                throw new ArgumentException("This subject with this teacher already exists");
            }

            Subjects subject = new Subjects();
            subject.SubjectTitle = title;
            subject.TeacherId = teacherId;
            context.Subjects.Add(subject);
            return this.context.SaveChanges();
        }
        public ICollection<Subjects> GetSubjectsByGradeId(int gradeId)
        {
            return this.context.Subjects
                .Include(s => s.Grade)
                .Include(s => s.Teacher)
                .Include(s => s.Marks)
                .Where(s => s.GradeId == gradeId)
                .ToList();
        }
        public int RemoveSubject(int subjectId)
        {
            context.Remove(context.Subjects.Where(t => t.TeacherId == subjectId).FirstOrDefault());
            return this.context.SaveChanges();
        }
        private MarkBookDBContext context;
        public SubjectDAO(MarkBookDBContext context)
        {
            if (context == null) throw new ArgumentNullException("context");
            this.context = context;
        }
    }
}
