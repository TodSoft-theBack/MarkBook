using System;
using System.Collections.Generic;
using System.Text;

namespace Markbook.Services.Models
{
    public partial class gradessubjects
    {
        public int GradeID { get; set; }
        public int subjectID { get; set; }

        public virtual Grades Grade { get; set; }
        public virtual Subjects Subject { get;set; }
        public virtual ICollection<Subjects> Subjects { get; set; }
    }
}
