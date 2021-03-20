using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Models
{
    public partial class Admins 
    {
        public int AdminID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int UserID { get; set; }
    }
}
