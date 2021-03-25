using Business.ControllerExceptions;
using Services;
using Services.DAO;
using Services.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Controllers
{
    public class LogInController
    {
        public Object LogInInfo { get; set; }
        public int Login(string username, string password)
        {
            Users user = this.loginDAO.LogIn(username, password);
            if (user == null)
            {
                throw new IncorectCredentialsException("Incorect credentials");
            }
            else
            {
                Students student = this.studentDAO.GetStudentByUserID(user.UserId);
                Teachers teacher;
                Admins admin;
                if (student != null)
                {
                    LogInInfo = student;
                    return 0;
                }
                else
                {
                    teacher = this.teacherDAO.GetTeacherByUserID(user.UserId);
                }
                if (teacher != null)
                {
                    LogInInfo = teacher;
                    return 1;
                }
                else
                {
                    admin = this.adminDAO.GetAdminByUserID(user.UserId);
                }
                if (admin != null)
                {
                    LogInInfo = admin;
                    return 2;
                }
                throw new ArgumentException("There is no such student,admin or teacher");
            }
            throw new ArgumentException("There is no such student,admin or teacher");
        }

        private LogInDAO loginDAO { get; set; }
        private StudentDAO studentDAO { get; set; }
        private AdminDAO adminDAO { get; set; }
        private TeacherDAO teacherDAO { get; set; }
        public LogInController(MarkBookDBContext context)
        {
            this.loginDAO = new LogInDAO(context);
            this.studentDAO = new StudentDAO(context);
            this.adminDAO = new AdminDAO(context);
            this.teacherDAO = new TeacherDAO(context);
        }
    }
}
