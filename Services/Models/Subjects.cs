using System;
using System.Collections.Generic;

namespace Services.Models
{
    public partial class Subjects
    {
        public Subjects()
        {
            Marks = new HashSet<Marks>();
        }

        public int SubjectId { get; set; }
        public string SubjectTitle { get; set; }
        public int GradeId { get; set; }
        public int TeacherId { get; set; }

        public virtual Grades Grade { get; set; }
        public virtual Teachers Teacher { get; set; }
        public virtual ICollection<Marks> Marks { get; set; }
    }
}
