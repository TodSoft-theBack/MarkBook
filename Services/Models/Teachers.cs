using System;
using System.Collections.Generic;

namespace Services.Models
{
    public partial class Teachers
    {
        public Teachers()
        {
            Subjects = new HashSet<Subjects>();
        }

        public int TeacherId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int UserId { get; set; }

        public virtual Users User { get; set; }
        public virtual ICollection<Subjects> Subjects { get; set; }
    }
}
