namespace Services.Models
{
    public partial class Subjects
    {

        public int SubjectID { get; set; }

        public string SubjectTitle { get; set; }

        public int TeacherID { get; set; }

        public virtual Teachers Teacher { get; set; }
    }
}