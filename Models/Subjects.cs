using System;
using System.Collections.Generic;
using System.Text;

namespace Markbook.Services.Models
{
    public partial class Subjects
    {

        public int SubjectID { get; set; }
        public string SubjectTitle { get; set; }
        public int TeacherID { get; set; }
    }
}
