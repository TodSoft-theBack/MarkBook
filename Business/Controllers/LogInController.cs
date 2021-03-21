using Services.DAO;
using Services.Models;
using Business.ControllerExceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Controllers
{
    public class LogInController
    {
        public void Login(string username, string password)
        {
            Users user = this.UserDAO.GetUser(username);
            if (user == null)
                throw new IncorectCredentialsException("There is no such user! If you want to get registerd contact an admin!");
            else
            {
                if (user.Password != password)
                    throw new IncorectCredentialsException("Wrong password");
                else
                {

                }
            }
        }
        public UserDAO UserDAO { get; set; }
        public LogInController(UserDAO context)
        {
            this.UserDAO = context;
        }
    }
}
