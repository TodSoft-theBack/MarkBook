using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Models
{
    public partial class Grades
    {
        public Grades()
        {
            Subjects = new HashSet<Subjects>();
        }

        public int GradeID { get; set; }

        public int GradeNumber { get; set; }

        public string GradeForm { get; set; }

        public virtual ICollection<Subjects> Subjects { get; set; }

    }
}
