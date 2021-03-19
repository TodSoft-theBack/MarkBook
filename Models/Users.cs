using System;
using System.Collections.Generic;
using System.Text;

namespace Markbook.Services.Models
{
    public partial class Users
    {
        public Users()
        {

        }

        public int UserID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int Role_ID { get; set; }

        public virtual ICollection<Marks> Marks { get; set; }

    }
}
