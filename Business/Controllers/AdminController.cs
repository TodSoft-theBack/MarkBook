using System;
using System.Collections.Generic;
using System.Text;
using Services.DAO;
using Services.Models;
using Business.ViewModels;

namespace Business.Controllers
{
    public class AdminController
    {
        private AdminDAO AdminDAO { get; set; }
        public RegistrationViewModel GetAdminById(int id)
        {
            Admins admin = this.AdminDAO.GetAdminById(id);
            RegistrationViewModel registrationViewModel = new RegistrationViewModel();
            registrationViewModel.FirstName = admin.FirstName;
            registrationViewModel.LastName = admin.LastName;

            return registrationViewModel;
        }

        public void Register(RegistrationViewModel registrationViewModel)
        {
            Admins admin = new Admins();
            admin.FirstName = registrationViewModel.FirstName;
            admin.LastName = registrationViewModel.LastName;

            Users loginInfo = new Users();
            loginInfo.Username = registrationViewModel.Username;
            loginInfo.Password = registrationViewModel.Password;
        }

        private AdminDAO admiNDAO = null;
        public  AdminController(AdminDAO adminDAO)
        {
            this.AdminDAO = adminDAO;
        }
    }
}
