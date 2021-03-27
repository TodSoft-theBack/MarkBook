using Business.ViewModels;
using Services;
using Services.DAO;
using Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Controllers
{
    public class TeacherController
    {
        private TeacherDAO teacherDAO { get; set; }
        private MarkDAO markDAO { get; set; }
        private StudentDAO studentDAO { get; set; }
        private GradeDAO gradeDAO { get; set; }

        public RegistrationViewModel GetTeacherById(int id)
        {
            Teachers teacher = teacherDAO.GetTeacherById(id);
            RegistrationViewModel registrationViewModel = new RegistrationViewModel();
            registrationViewModel.FirstName = teacher.FirstName;
            registrationViewModel.LastName = teacher.LastName;
            return registrationViewModel;
        }
        public ICollection<Subjects> GetSubjects(int teacherID)
        {
            return this.teacherDAO.GetTeacherSubjects(teacherID);
        }
        public TeacherViewModel GetTeacherData(int teacherID, int subjectId)
        {
            Dictionary<Students, ICollection<Marks>> teacherData = new Dictionary<Students, ICollection<Marks>>();
            Subjects subject = this.GetSubjects(teacherID).FirstOrDefault(s => s.SubjectId == subjectId);
            foreach (var student in this.studentDAO.AllStudentsFromGrade(subject.GradeId))
            {
                teacherData.Add(student, this.markDAO.GetMarksOfStudentForGivenSubjectById(subjectId, student.StudentId));
            }
            return new TeacherViewModel()
            {
                Data = teacherData
            };
        }
        public void RemoveMarkById(int markId)
        {
            this.markDAO.RemoveMark(markId);
        }
        public ICollection<Students> GetStudentsByGradeId(int gradeId)
        {
            return gradeDAO.GetStudentsByGradeId(gradeId);
        }
        public void AddMark(decimal markValue, int subjectId, int studentId, string comment)
        {
            markDAO.AddMark(markValue, subjectId, studentId, comment);
        }
        public TeacherController(MarkBookDBContext context)
        {
            this.teacherDAO = new TeacherDAO(context);
            this.markDAO = new MarkDAO(context);
            this.gradeDAO = new GradeDAO(context);
            this.studentDAO = new StudentDAO(context);
        }
    }
}
