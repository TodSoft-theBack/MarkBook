using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ViewModels
{
    public interface IViewModel
    {
        public List<string> Title { get;}
        public List<List<string>> Marks { get;}
        public int Count { get; }
    }
}
