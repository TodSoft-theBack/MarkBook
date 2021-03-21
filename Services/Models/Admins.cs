using System;
using System.Collections.Generic;

namespace Services.Models
{
    public partial class Admins
    {
        public int AdminId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int UserId { get; set; }

        public virtual Users User { get; set; }
    }
}
