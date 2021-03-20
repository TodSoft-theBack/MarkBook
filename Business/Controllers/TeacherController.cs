using System;
using System.Collections.Generic;
using System.Text;
using Services.DAO;
using Services.Models;
using Business.ViewModels;

namespace Business.Controllers
{
    class TeacherController
    {
        public RegistrationViewModel GetTeacherById(int id)
        {
            Teachers teacher = teacherDAO.GetTeacherById(id);
            RegistrationViewModel registrationViewModel = new RegistrationViewModel();
            registrationViewModel.FirstName =teacher.FirstName;
            registrationViewModel.LastName = teacher.LastName;
            return registrationViewModel;
        }

        private TeacherDAO teacherDAO = null;
        public TeacherController(TeacherDAO teacherDAO)
        {
            this.teacherDAO = teacherDAO;
        }
    }
}
