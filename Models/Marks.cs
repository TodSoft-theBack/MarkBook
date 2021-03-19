using System;
using System.Collections.Generic;
using System.Text;

namespace Markbook.Services.Models
{
    public partial class Marks
    {
        public int MarkID { get; set; }
        public double MarkValue { get; set; }
        public int SubjectID { get; set; }
        public int StudentID { get; set; }
        public string Comment { get; set; }
    }
}
