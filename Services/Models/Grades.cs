using System;
using System.Collections.Generic;

namespace Services.Models
{
    public partial class Grades
    {
        public Grades()
        {
            Subjects = new HashSet<Subjects>();
        }

        public int GradeId { get; set; }
        public int GradeNumber { get; set; }
        public string GradeForm { get; set; }

        public virtual ICollection<Subjects> Subjects { get; set; }
    }
}
