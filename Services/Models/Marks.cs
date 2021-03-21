using System;
using System.Collections.Generic;

namespace Services.Models
{
    public partial class Marks
    {
        public int MarkId { get; set; }
        public decimal MarkValue { get; set; }
        public int SubjectId { get; set; }
        public int StudentId { get; set; }
        public string Comment { get; set; }

        public virtual Students Student { get; set; }
        public virtual Subjects Subject { get; set; }
    }
}
