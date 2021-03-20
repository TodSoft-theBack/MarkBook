using Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarkBook
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }

        private void LogInForm_Load(object sender, EventArgs e)
        {
            NavBar.BackColor = Color.FromArgb(DrawingFunctions.GetAlphaFromPercent(30), NavBar.BackColor);
            ButtonBoard.BackColor = Color.FromArgb(DrawingFunctions.GetAlphaFromPercent(30), ButtonBoard.BackColor);
            buttonLogIn.BackColor = Color.FromArgb(255, 95, 165, 255);
            LabelFormText.Text = this.Text;
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
        private void minimizeButton_Click(object sender, EventArgs e ) 
            => this.WindowState = FormWindowState.Minimized;
        private void CloseButton_Click(object sender, EventArgs e) 
            => Application.Exit();
        private void NormalizeMaximizeForm_Click(object sender, EventArgs e)
        => this.WindowState = 
            (this.WindowState == FormWindowState.Maximized) ?
            FormWindowState.Normal : 
            FormWindowState.Maximized;
        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text,
                   password = textBoxPassword.Text;
            using (Form form = new TeacherView())
                form.ShowDialog();
        }
    }
}
