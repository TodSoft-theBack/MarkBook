using System;
using System.Collections.Generic;

namespace Services.Models
{
    public partial class Students
    {
        public Students()
        {
            Marks = new HashSet<Marks>();
        }

        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int GradeId { get; set; }
        public int? UserId { get; set; }

        public virtual Users User { get; set; }
        public virtual Grades Grade { get; set; }
        public virtual ICollection<Marks> Marks { get; set; }
    }
}
