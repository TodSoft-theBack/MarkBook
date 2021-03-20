using System.Collections.Generic;

namespace Services.Models
{
    public partial class Teachers
    {
        public Teachers()
        {
            Subjects = new HashSet<Subjects>();
        }

        public int TeacherID { get; set; }
        
        public string FirstName { get; set; }
        
        public string LastName { get; set; }
        
        public int UserID { get; set; }

        public virtual ICollection<Subjects> Subjects { get; set; }
    }
}