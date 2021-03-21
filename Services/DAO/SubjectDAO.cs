using System;
using System.Collections.Generic;
using System.Linq;

namespace Services.Models
{
    public partial class SubjectDAO
    {
        public int AddSubject(string title, int teacherId)
        {
            Subjects subject = new Subjects();
            subject.SubjectTitle = title;
            subject.TeacherId = teacherId;
            context.Subjects.Add(subject);
            return this.context.SaveChanges();
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
