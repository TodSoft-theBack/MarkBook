using System.Collections.Generic;

namespace Services.Models
{
    public partial class Students
    {
        public Students()
        {
            Marks = new HashSet<Marks>();
        }

        public int StudentID { get; set; }
        
        public string FirstName { get; set; }
        
        public string LastName { get; set; }
        
        public int UserID { get; set; }
        
        public int GradeID { get; set; }

        public virtual Grades Grade { get; set; }
        public virtual ICollection<Marks> Marks { get; set; }
    }
}