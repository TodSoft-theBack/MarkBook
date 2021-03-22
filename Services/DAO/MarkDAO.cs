using Microsoft.EntityFrameworkCore;
using Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Services.DAO
{
    public partial class MarkDAO
    {
        public int AddMark(int markValue, int subjectId, int studentId, string comment)
        {
            if (markValue < 2 || markValue > 6)
            {
                throw new ArgumentOutOfRangeException("Mark must be between 2 and 6");
            }
            Marks mark = new Marks
            {
                MarkValue = markValue,
                SubjectId = subjectId,
                StudentId = studentId,
                Comment = comment
            };

            this.context.Marks.Add(mark);
            return this.context.SaveChanges();
        }

        public int RemoveMark(int id)
        {
            context.Remove(context.Marks.Where(m => m.MarkId == id).FirstOrDefault());
            return context.SaveChanges();
        }
        public Marks GetMarkById(int markId)
        {
            return this.context.Marks
                       .FirstOrDefault(m => m.MarkId == markId);
        }
        public List<Marks> GetAllMarksOfStudentById(int studentId)
        {
            var marks = this.context.Marks
                .Where(st => st.StudentId.Equals(studentId))
                .ToList();
            return marks;
        }
        public List<Marks> GetMarksForGivenSubjectById(int subjectId, int studentId) //vrushta ocenkite za predmeta
        {
            return this.context.Marks
              .Where(s => s.SubjectId.Equals(subjectId) && s.StudentId.Equals(studentId))
              .ToList();
        }
        public List<Marks> GetMarksForGivenSubjectById(int subjectId) //vrushta vsichki ocenki za daden predmet na vsichki uchenici
        {
            return this.context.Marks
                .Include(s => s.Student)
              .Where(s => s.SubjectId.Equals(subjectId))
              .ToList();
        }

        private MarkBookDBContext context;
        public MarkDAO(MarkBookDBContext context)
        {
            if (context == null) throw new ArgumentNullException("context");

            this.context = context;
        }
    }
}
