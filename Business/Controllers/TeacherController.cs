using Business.ViewModels;
using Services;
using Services.DAO;
using Services.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Controllers
{
    public class TeacherController
    {
        private TeacherDAO teacherDAO { get; set; }
        public RegistrationViewModel GetTeacherById(int id)
        {
            Teachers teacher = teacherDAO.GetTeacherById(id);
            RegistrationViewModel registrationViewModel = new RegistrationViewModel();
            registrationViewModel.FirstName = teacher.FirstName;
            registrationViewModel.LastName = teacher.LastName;
            return registrationViewModel;
        }
        public List<string> Subjects(int teacherID)
        {
            List<string> output = new List<string>();
            foreach (var subject in this.teacherDAO.GetTeacherSubjects(teacherID))
            {
                output.Add(string.Format($"{subject.SubjectTitle}({subject.Grade.GradeNumber}{subject.Grade.GradeForm})"));
            }
            return output;
        }
        public TeacherViewModel GetTeacherData(int techerID, int gradeID)
        {
            Dictionary<Students, ICollection<Marks>> teacherData = new Dictionary<Students, ICollection<Marks>>();
            
            return new TeacherViewModel()
            {
                Data = teacherData
            };
        }
        public TeacherController(MarkBookDBContext context)
        {
            this.teacherDAO = new TeacherDAO(context);
        }
    }
}
