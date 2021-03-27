using Business.ViewModels;
using Services;
using Services.DAO;
using Services.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Controllers
{
    public class AdminController
    {
        private AdminDAO AdminDAO { get; set; }
        private GradeDAO GradeDAO { get; set; }
        private SubjectDAO SubjectDAO { get; set; }
        private TeacherDAO TeacherDAO { get; set; }
        private StudentDAO StudentDAO { get; set; }
        public RegistrationViewModel GetAdminById(int id)
        {
            Admins admin = this.AdminDAO.GetAdminByID(id);
            RegistrationViewModel registrationViewModel = new RegistrationViewModel();
            registrationViewModel.FirstName = admin.FirstName;
            registrationViewModel.LastName = admin.LastName;

            return registrationViewModel;
        }
        public ICollection<Grades> GetAllGrades()
        {
            return this.GradeDAO.GetAllGrades();
        }
        public ICollection<Subjects> GetSubjectsByGradeId(int gradeId)
        {
            return this.SubjectDAO.GetSubjectsByGradeId(gradeId);
        }
        public ICollection<Students> GetStudentsByGradeId(int gradeId)
        {
            return this.StudentDAO.GetStudentsByGradeId(gradeId);
        }
        public ICollection<Teachers> GetTeachersByGradeId(int gradeId)
        {
            return this.TeacherDAO.GetTeachersByGradeId(gradeId);
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
        public AdminController(MarkBookDBContext context)
        {
            this.AdminDAO = new AdminDAO(context);
            this.GradeDAO = new GradeDAO(context);
            this.TeacherDAO = new TeacherDAO(context);
            this.StudentDAO = new StudentDAO(context);
            this.SubjectDAO = new SubjectDAO(context);
        }
    }
}
