using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MarkBook
{
    public partial class TeacherView : Form
    {
        public TeacherView()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
            => this.Close();

        private void TeacherView_Load(object sender, EventArgs e)
        {
            labelFormText.Text = this.Text;
            NavBar.BackColor = Color.FromArgb(LogInForm.GetAlphaFromPercent(30), NavBar.BackColor);
            studentsHeader.BackColor = Color.FromArgb(LogInForm.GetAlphaFromPercent(30), studentsHeader.BackColor);
            marksHeader.BackColor = Color.FromArgb(LogInForm.GetAlphaFromPercent(30), marksHeader.BackColor);
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
