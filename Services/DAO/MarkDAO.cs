using System;
using System.Collections.Generic;
using System.Text;
using Services.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Services;


namespace Services.DAO
{
    public class MarkDAO
    {
        public int AddMark(int markValue, int subjectId, int studentId, string comment)
        {
            if (markValue < 2 || markValue > 6)
            {
                throw new ArgumentOutOfRangeException("Mark must be between 2 and 6");
            }
            Marks mark = new Marks();
            mark.MarkValue = markValue;
            mark.SubjectID = subjectId;
            mark.StudentID = studentId;
            mark.Comment = comment;

            this.context.Marks.Add(mark);
            return this.context.SaveChanges();
        }
        
        public int RemoveMark(int id)
        {
            context.Remove(context.Marks.Where(m => m.MarkID == id).FirstOrDefault());
            return context.SaveChanges();
        }

        public Marks GetMarkById(int markId)
        {
            return this.context.Marks
                       .FirstOrDefault(m => m.MarkID == markId);
        }

        public List<Marks> GetAllMarksOfStudentById(int studentId)
        {
            var marks = this.context.Marks
                .Where(st => st.StudentID.Equals(studentId))
                .ToList();

            return marks;
        }

        public List<Marks> GetMarksForGivenSubjectById(int subjectId, int studentId) //vrushta ocenkite za predmeta
        {
            var marks = this.context.Marks
              .Where(s => s.SubjectID.Equals(subjectId) && s.StudentID.Equals(studentId))
              .ToList();

            return marks;
        }

        private MarkBookDBContext context;
        public MarkDAO(MarkBookDBContext context)
        {
            if (context == null) throw new ArgumentNullException("context");

            this.context = context;
        }
    }
}
