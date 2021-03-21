using System;
using System.Collections.Generic;

namespace Services.Models
{
    public partial class Users
    {
        public Users()
        {
            Admins = new HashSet<Admins>();
            Students = new HashSet<Students>();
        }

        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public virtual Teachers Teachers { get; set; }
        public virtual ICollection<Admins> Admins { get; set; }
        public virtual ICollection<Students> Students { get; set; }
    }
}
