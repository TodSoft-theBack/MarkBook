using Business.Controllers;
using Services;
using Services.DAO;
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
    public partial class StudentView : Form
    {
        public StudentView()
        {
            InitializeComponent();
        }
        public Students student { get; set; }
        public StudentController StudentController { get; set; }
        MarkBookDBContext context = new MarkBookDBContext();
        private void StudentView_Load(object sender, EventArgs e)
        {
            student = (Students)((LogInForm)this.Owner).LogInInfo;
            this.StudentController = new StudentController(((LogInForm)this.Owner).Database);
            labelFormText.Text = string.Format($"MarkBook(Student) - {student.FirstName} {student.LastName}");
            NavBar.BackColor = Color.FromArgb(DrawingFunctions.GetAlphaFromPercent(30), NavBar.BackColor);
            subjectsHeader.BackColor = Color.FromArgb(DrawingFunctions.GetAlphaFromPercent(30), subjectsHeader.BackColor);
            marksHeader.BackColor = Color.FromArgb(DrawingFunctions.GetAlphaFromPercent(30), marksHeader.BackColor);
            DrawingFunctions.DrawTable(this,StudentController.GetStudentData(student.StudentId), subjectsHeader, marksHeader);
            DrawingFunctions.SetHover(closeButton, minimizeButton);
        }
        private void CloseButton_Click(object sender, EventArgs e)
            => this.Close();
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
                this.Location = new Point(this.Location.X - firstLocation.X + e.X, this.Location.Y - firstLocation.Y + e.Y);
        }
        private void minimizeButton_Click(object sender, EventArgs e)
            => this.WindowState = FormWindowState.Minimized;
    }
}
