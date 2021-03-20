using System;
using System.Collections.Generic;
using System.Text;
using Services.DAO;
using Services.Models;
using Business.ViewModels;
using Business.IncorectCredentialsException;

namespace Business.Controllers
{
    public class HomeController
    {
        public int Login(string username, string password)
        {
            Users user = this.homeDAO.LogIn(username, password);
            if (user == null)
            {
                throw new IncorectCredentialsException("Incorect credentials");
            }
            else
            {
                return user.Id;
            }
        }

        private HomeDAO homeDAO = null;
        public HomeController(HomeDAO homeDAO)
        {
            this.homeDAO = homeDAO;

        }
    }
}
