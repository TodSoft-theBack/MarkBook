using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ViewModels
{
    interface IViewModel
    {
        public string NameTitle { get; set; }
        public string Marks { get; set; }
    }
}
