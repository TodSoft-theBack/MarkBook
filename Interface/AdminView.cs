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
    public partial class AdminView : Form
    {
        public AdminView()
        {
            InitializeComponent();
        }
        Admins admin;
        AdminController teacherController;
        MarkBookDBContext context;
        private void AdminView_Load(object sender, EventArgs e)
        {
            admin = (Admins)((LogInForm)this.Owner).LogInInfo;
            context = ((LogInForm)this.Owner).Database;
            teacherController = new AdminController(context);
            labelFormText.Text = string.Format($"MarkBook(Teacher) - {admin.FirstName} {admin.LastName}");
            NavBar.BackColor = Color.FromArgb(DrawingFunctions.GetAlphaFromPercent(30), NavBar.BackColor);
            buttonAddGrade  .BackColor = Color.FromArgb(DrawingFunctions.GetAlphaFromPercent(20), buttonAddGrade.BackColor);
            buttonAddStudent.BackColor = Color.FromArgb(DrawingFunctions.GetAlphaFromPercent(20), buttonAddStudent.BackColor);
            buttonAddSubject.BackColor = Color.FromArgb(DrawingFunctions.GetAlphaFromPercent(20), buttonAddSubject.BackColor);
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
    }
}
