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
        public Object LogInInfo { get; set; }
        public int Login(string username, string password)
        {
            Users user = this.homeDAO.LogIn(username, password);
            if (user == null)
            {
                throw new IncorectCredentialsException("Incorect credentials");
            }
            else
            {
                Students student = this.studentDAO.GetStudentByUserID(user.UserID);
                Teachers teacher = this.teacherDAO.GetTeacherByUserID(user.UserID);
                Admins admin = this.adminDAO.GetAdminByUserID(user.UserID);
                if (student != null)
                {
                    LogInInfo = student;
                    return 0;
                }               
                else if (teacher != null)
                {
                    LogInInfo = teacher;
                    return 1;
                }
                else if(admin != null)
                {
                    LogInInfo = admin;
                    return 2;
                }
                else
                    throw new ArgumentException("There is no such student,admin or teacher");
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
