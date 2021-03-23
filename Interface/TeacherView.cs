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
    public partial class TeacherView : Form
    {
        public TeacherView()
        {
            InitializeComponent();
        }
        Teachers teacher;
        TeacherController teacherController;
        public ICollection<Subjects> Subjects;
        MarkBookDBContext context;
        private void CloseButton_Click(object sender, EventArgs e)
            => this.Close();
        public static string SubjectToString(Subjects subject)
            => string.Format($"{subject.SubjectTitle} (Grade: {subject.Grade.GradeNumber}{subject.Grade.GradeForm})");
        private void TeacherView_Load(object sender, EventArgs e)
        {
            teacher = (Teachers)((LogInForm)this.Owner).LogInInfo;
            context = ((LogInForm)this.Owner).Database;
            teacherController = new TeacherController(context);
            labelFormText.Text = string.Format($"MarkBook(Teacher) - {teacher.FirstName} {teacher.LastName}");
            comboBoxGrade.Items.Clear();
            this.Subjects = teacherController.GetSubjects(teacher.TeacherId);
            foreach (var subject in this.Subjects.Select(s => SubjectToString(s)))
                comboBoxGrade.Items.Add(subject);
            NavBar.BackColor = Color.FromArgb(DrawingFunctions.GetAlphaFromPercent(30), NavBar.BackColor);
            studentsHeader.BackColor = Color.FromArgb(DrawingFunctions.GetAlphaFromPercent(30), studentsHeader.BackColor);
            marksHeader.BackColor = Color.FromArgb(DrawingFunctions.GetAlphaFromPercent(30), marksHeader.BackColor);
            tableCellSubject.FillColor = Color.FromArgb(DrawingFunctions.GetAlphaFromPercent(30), tableCellSubject.FillColor);
            DrawingFunctions.SetHover(minimizeButton, closeButton);
            if (comboBoxGrade.SelectedIndex >= 0)
            {
                DrawingFunctions.DrawTable(
                    this,
                    teacherController.GetTeacherData(teacher.TeacherId, Subjects.ElementAt(comboBoxGrade.SelectedIndex).SubjectId),
                    studentsHeader,
                    marksHeader
                    );
            }
        }

        Point firstLocation = new Point();
        bool MouseIsDown = false;
        private void NavBar_MouseUp(object sender, MouseEventArgs e)
            => MouseIsDown = false;
        private void NavBar_MouseDown(object sender, MouseEventArgs e)
        {
            MouseIsDown = true;
            firstLocation = e.Location;
        }
        private void NavBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (MouseIsDown)
            {
                this.Location = new Point(this.Location.X - firstLocation.X + e.X, this.Location.Y - firstLocation.Y + e.Y);
            }
        }

        private void comboBoxGrade_SelectedIndexChanged(object sender, EventArgs e)
        {
            DrawingFunctions.DisposeTable(this, studentsHeader);
            DrawingFunctions.DisposeTable(this, marksHeader);
            if (comboBoxGrade.SelectedIndex >= 0)
            {
                DrawingFunctions.DrawTable(this, teacherController.GetTeacherData(teacher.TeacherId, Subjects.ElementAt(comboBoxGrade.SelectedIndex).SubjectId), studentsHeader, marksHeader);
            }
        }

        private void buttonAddMark_Click(object sender, EventArgs e)
        {

        }

        private void minimizeButton_Click(object sender, EventArgs e)
         => this.WindowState = FormWindowState.Minimized;
    }
}
