using System;
using System.Collections.Generic;
using System.Text;
using Services.DAO;
using Services.Models;
using Business.ViewModels;
using Business.ControllerExceptions;
using Services;

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
                if (this.studentDAO.GetStudentByUserID(user.UserID) != null)
                    return 0;
                else if (this.teacherDAO.GetStudentByUserID(user.UserID) != null)
                    return 1;
            }
            throw new ArgumentException("There is no such student,admin or teacher");
        }

        private HomeDAO homeDAO { get; set; }
        private StudentDAO studentDAO { get; set; }
        private AdminDAO adminDAO { get; set; }
        private TeacherDAO teacherDAO { get; set; }
        public HomeController(MarkBookDBContext context)
        {
            this.homeDAO = new HomeDAO(context);
            this.studentDAO = new StudentDAO(context);
            this.adminDAO = new AdminDAO(context);
            this.teacherDAO = new TeacherDAO(context);
        }
    }
}
