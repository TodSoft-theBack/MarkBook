using System;
using System.Collections.Generic;
using System.Text;
using Services.DAO;
using Services.Models;
using Business.ViewModels;

namespace Business.Controllers
{
    public class StudentController
    {
        private  StudentDAO StudentDAO { get; set; }
        public RegistrationViewModel GetStudentById(int id)
        {
            Students student = StudentDAO.GetStudentById(id);
            RegistrationViewModel registrationViewModel = new RegistrationViewModel();
            registrationViewModel.FirstName = student.FirstName;
            registrationViewModel.LastName = student.LastName;
            return registrationViewModel;
        }

        public StudentController(StudentDAO studentDAO)
        {
            this.StudentDAO = studentDAO;
        }
    }
}
