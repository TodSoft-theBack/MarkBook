using Business.Controllers;
using Services;
using Services.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace Interface
{
    public partial class AdminView : Form
    {
        public AdminView()
        {
            InitializeComponent();
        }
        Admins admin;
        AdminController adminController;
        List<Grades> grades = new List<Grades>();

        MarkBookDBContext Database;
        private static string ConvertGradeToString(Grades grade)
            => string.Format($"Grade: {grade.GradeNumber}{grade.GradeForm}");
        private static string ConvertStudentToString(Students student)
            => string.Format($"{student.FirstName} {student.LastName}");
        private static string ConvertTeacherToString(Teachers teacher)
            => string.Format($"{teacher.FirstName} {teacher.LastName}");

        private void AdminView_Load(object sender, EventArgs e)
        {
            admin = (Admins)((LogInForm)this.Owner).LogInInfo;
            Database = ((LogInForm)this.Owner).Database;
            adminController = new AdminController(Database);
            labelFormText.Text = string.Format($"MarkBook(Admin) - {admin.FirstName} {admin.LastName}");
            NavBar.BackColor = Color.FromArgb(DrawingFunctions.GetAlphaFromPercent(30), NavBar.BackColor);
            buttonAddGrade.BackColor = Color.FromArgb(DrawingFunctions.GetAlphaFromPercent(20), buttonAddGrade.BackColor);
            buttonAddStudent.BackColor = Color.FromArgb(DrawingFunctions.GetAlphaFromPercent(20), buttonAddStudent.BackColor);
            buttonAddSubject.BackColor = Color.FromArgb(DrawingFunctions.GetAlphaFromPercent(20), buttonAddSubject.BackColor);
            this.grades = (List<Grades>)this.adminController.GetAllGrades();
            comboBoxGrade.Items.AddRange(grades.Select(g => ConvertGradeToString(g)).ToArray());
        }
        Point firstLocation = new Point();
        bool MouseIsDown = false;
        private void NavBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (MouseIsDown)
            {
                this.Location = new Point(this.Location.X - firstLocation.X + e.X, this.Location.Y - firstLocation.Y + e.Y);
            }
        }
        private void NavBar_MouseDown(object sender, MouseEventArgs e)
        {
            MouseIsDown = true;
            firstLocation = e.Location;
        }
        private void NavBar_MouseUp(object sender, MouseEventArgs e)
            => MouseIsDown = false;
        private void MinimizeButton_Click(object sender, EventArgs e)
            => this.WindowState = FormWindowState.Minimized;
        private void CloseButton_Click(object sender, EventArgs e)
            => this.Close();
        private void NormalizeMaximizeForm_Click(object sender, EventArgs e)
        => this.WindowState =
            (this.WindowState == FormWindowState.Maximized) ?
            FormWindowState.Normal :
            FormWindowState.Maximized;

        private void comboBoxGrade_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxGrade.SelectedIndex > -1 &&
                comboBoxGrade.SelectedIndex < grades.Count)
            {
                //showing all subjects
                listBoxSubjects.Items.Clear();
                var subjects =
                    adminController.GetSubjectsByGradeId(grades[comboBoxGrade.SelectedIndex].GradeId)
                    .Select(s => s.SubjectTitle)
                    .ToList();
                foreach (var item in subjects)
                    listBoxSubjects.Items.Add(item);

                //showing all students
                listBoxStudents.Items.Clear();
                var students =
                    adminController.GetStudentsByGradeId(grades[comboBoxGrade.SelectedIndex].GradeId)
                    .Select(s => ConvertStudentToString(s))
                    .ToList();
                foreach (var item in students)
                    listBoxStudents.Items.Add(item);

                //showing all teachers
                listBoxTeachers.Items.Clear();
                var teachers =
                    adminController.GetTeachersByGradeId(grades[comboBoxGrade.SelectedIndex].GradeId)
                    .Select(t => ConvertTeacherToString(t))
                    .ToList();
                foreach (var item in teachers)
                    listBoxTeachers.Items.Add(item);
            }
        }
    }
}
