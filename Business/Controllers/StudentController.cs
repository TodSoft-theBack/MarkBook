using Business.ViewModels;
using Services;
using Services.DAO;
using Services.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Controllers
{
    public class StudentController
    {
        private StudentDAO StudentDAO { get; set; }
        private GradeDAO GradeDAO { get; set; }
        public MarkDAO MarkDAO { get; set; }
        public RegistrationViewModel GetStudentById(int id)
        {
            Students student = StudentDAO.GetStudentById(id);
            RegistrationViewModel registrationViewModel = new RegistrationViewModel();
            registrationViewModel.FirstName = student.FirstName;
            registrationViewModel.LastName = student.LastName;
            return registrationViewModel;
        }
        public StudentViewModel GetStudentData(int studentID)
        {
            Dictionary<Subjects, ICollection<Marks>> studentData = new Dictionary<Subjects, ICollection<Marks>>();
            Grades grade = this.GradeDAO.GetGrade(this.StudentDAO.GetStudentById(studentID).GradeId);
            foreach (var subject in grade.Subjects)
            {
                studentData.Add(subject, this.MarkDAO.GetMarksForGivenSubjectById(subject.SubjectId, studentID));
            }
            return new StudentViewModel()
            {
                Data = studentData
            };          
        }
        public StudentController(MarkBookDBContext context)
        {
            this.StudentDAO = new StudentDAO(context);
            this.GradeDAO = new GradeDAO(context);
            this.MarkDAO = new MarkDAO(context);
        }
    }
}
