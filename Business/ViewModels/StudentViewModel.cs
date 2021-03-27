using Services.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ViewModels
{
    public class StudentViewModel : IViewModel
    {
        public Dictionary<Subjects, ICollection<Marks>> Data { get; set; }
        public List<string> Title
        {
            get
            {
                List<string> output = new List<string>();
                foreach (var subject in this.Data.Keys)
                    output.Add(subject.SubjectTitle);
                return output;
            }
        }
        public List<List<string>> Marks
        {
            get
            {
                List<List<string>> output = new List<List<string>>();
                foreach (var subject in this.Data.Keys)
                {
                    List<string> _ = new List<string>();
                    foreach (var marks in this.Data[subject])
                        _.Add(marks.MarkValue.ToString());
                    output.Add(_);
                }
                return output;
            }
        }

        public int Count { get => this.Data.Count; }
    }
}
