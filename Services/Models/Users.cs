using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Models
{
    public partial class Users
    {
        public int UserID { get; set; }
        
        public string Username { get; set; }
        
        public string Password { get; set; }
    }
}
