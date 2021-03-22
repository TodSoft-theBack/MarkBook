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

namespace Interface
{
    public partial class TeacherView : Form
    {
        public TeacherView()
        {
            InitializeComponent();
        }
        Teachers teacher { get; set; }
        TeacherController teacherController { get; set; }
        MarkBookDBContext context = new MarkBookDBContext();
        private void CloseButton_Click(object sender, EventArgs e)
            => this.Close();
        private void TeacherView_Load(object sender, EventArgs e)
        {
            teacher = (Teachers)((LogInForm)this.Owner).LogInInfo;
            context = ((LogInForm)this.Owner).Database;
            teacherController = new TeacherController(context);
            labelFormText.Text = string.Format($"MarkBook(Teacher) - {teacher.FirstName} {teacher.LastName}");
            NavBar.BackColor = Color.FromArgb(DrawingFunctions.GetAlphaFromPercent(30), NavBar.BackColor);
            studentsHeader.BackColor = Color.FromArgb(DrawingFunctions.GetAlphaFromPercent(30), studentsHeader.BackColor);
            marksHeader.BackColor = Color.FromArgb(DrawingFunctions.GetAlphaFromPercent(30), marksHeader.BackColor);
            DrawingFunctions.DrawTable(this, teacherController.GetTeacherData(teacher.TeacherId, 1), studentsHeader, marksHeader);
        }
        private void TeacherView_TextChanged(object sender, EventArgs e)
            => labelFormText.Text = this.Text;

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
    }
}
