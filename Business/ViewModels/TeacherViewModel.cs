using Services.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ViewModels
{
    public class TeacherViewModel
    {
        public Dictionary<Students,ICollection<Marks>> Data { get; set; }
    }
}
