using Microsoft.EntityFrameworkCore;
using Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Services.DAO
{
    public partial class MarkDAO
    {
        public int AddMark(decimal markValue, int subjectId, int studentId, string comment)
        {
            decimal markValueToCompare = (decimal) Math.Round(markValue);
            if (markValueToCompare < 2 || markValueToCompare > 6)
            {
                throw new ArgumentOutOfRangeException("Mark must be between 2 and 6");
            }

            if (string.IsNullOrEmpty(comment))
            {
                throw new ArgumentException("Comment is required");
            }

            if (subjectId == 0)
            {
                throw new ArgumentException("SubjectID is required");
            }

            if (studentId == 0)
            {
                throw new ArgumentException("StudentId is required");
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
            if (id == 0)
            {
                throw new ArgumentException("This mark does not exist");
            }

            var mark = this.context.Marks.Where(m => m.MarkId == id).FirstOrDefault();

            if (mark == null)
            {
                throw new ArgumentException("This mark does not exist");
            }

            context.Remove(context.Marks.Where(m => m.MarkId == id).FirstOrDefault());
            return context.SaveChanges();
        }
        public Marks GetMarkById(int markId)
        {
            if (markId == 0)
            {
                throw new ArgumentException("This mark does not exist");
            }

            var mark = this.context.Marks.Where(m => m.MarkId == markId).FirstOrDefault();
            if (mark == null)
            {
                throw new ArgumentException("This mark does not exist");
            }

            return this.context.Marks.FirstOrDefault(m => m.MarkId == markId);
        }
        public List<Marks> GetAllMarksOfStudentById(int studentId)
        {
            if (studentId == 0)
            {
                throw new ArgumentException("This student does not exist");
            }

            var student = this.context.Students.Where(st => st.StudentId == studentId).FirstOrDefault();

            if (student == null)
            {
                throw new ArgumentException("This student does not exist");
            }

            List<Marks> marks = this.context.Marks
                .Where(st => st.StudentId == studentId)
                .ToList();

            if (!marks.Any())
            {
                throw new ArgumentException("This student does not have any marks");
            }

            return marks;
        }
        public List<Marks> GetMarksOfStudentForGivenSubjectById(int subjectId, int studentId)
        {
            if (subjectId == 0)
            {
                throw new ArgumentException("This subject does not exist");
            }

            var subject = this.context.Subjects.Where(s => s.SubjectId == subjectId).FirstOrDefault();
            if (subject == null)
            {
                throw new ArgumentException("This subject does not exist");
            }

            if (studentId == 0)
            {
                throw new ArgumentException("This student does not exist");
            }
            var student = this.context.Students.Where(st => st.StudentId == studentId).FirstOrDefault();

            if (student == null)
            {
                throw new ArgumentException("This student does not exist");
            }

            return this.context.Marks
              .Where(s => s.SubjectId == subjectId && s.StudentId == studentId)
              .ToList();
        }
        public List<Marks> GetMarksForGivenSubjectById(int subjectId)
        {
            if (subjectId == 0)
            {
                throw new ArgumentException("This subject does not exist");
            }

            Subjects subject = this.context.Subjects.Where(s => s.SubjectId == subjectId).FirstOrDefault();

            if (subject == null)
            {
                throw new ArgumentException("This subject does not exist");
            }

            List<Marks> marks = this.context.Marks.Where(m => m.SubjectId == subjectId).ToList();

            if (marks.Count == 0)
            {
                throw new ArgumentException("There are no marks related to the selected subject");
            }

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
