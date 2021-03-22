using Services.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ViewModels
{
    public class StudentViewModel
    {
        public Dictionary<Subjects, ICollection<Marks>> Data { get; set; }
    }
}
