using System.Collections.Generic;

namespace Services.Models
{
    public partial class Students
    {
        public int StudentID { get; set; }
        
        public string FirstName { get; set; }
        
        public string LastName { get; set; }
        
        public int UserID { get; set; }
        
        public int GradeID { get; set; }
    }
}