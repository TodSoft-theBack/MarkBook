using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Business.Controllers;
using Services;
using Services.Models;
using System.Linq;
using Business.ViewModels;

namespace Interface.AddDialogs
{
    public partial class AddMarkDialog : Form 
    {
        public AddMarkDialog()
        {
            InitializeComponent();
        }
        TeacherController addController;
        public Subjects subject = new Subjects();
        public List<Students> students = new List<Students>();
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
        private void CloseButton_Click(object sender, EventArgs e)
            => this.Close();
        private void minimizeButton_Click(object sender, EventArgs e)
         => this.WindowState = FormWindowState.Minimized;

        private void AddMarkDialog_Load(object sender, EventArgs e)
        {
            addController = ((TeacherView)this.Owner).teacherController;
            panelInfo.BackColor = Color.FromArgb(DrawingFunctions.GetAlphaFromPercent(30), panelInfo.BackColor);
            NavBar.BackColor = Color.FromArgb(DrawingFunctions.GetAlphaFromPercent(30), NavBar.BackColor);
            buttonPreview.BackColor = Color.FromArgb(DrawingFunctions.GetAlphaFromPercent(30), buttonPreview.BackColor);
        }

        private void buttonPreview_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var student in students)
                {
                    listBoxPreview.Items.Add
                    (
                        $"Value: {decimal.Parse(textBoxMarkValue.Text)} " +
                        $"Subject: {subject.SubjectId} " +
                        $"Student: {student.StudentId} " +
                        $"Comment: {textBoxComment.Text}"
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            buttonSubmit.Enabled = true;
            buttonDelete.Enabled = true;
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var student in students)
                {
                    addController.AddMark(decimal.Parse(textBoxMarkValue.Text), subject.SubjectId, student.StudentId, textBoxComment.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Mark added succesfully!", "Addition successful!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            this.Close();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            listBoxPreview.Items.Clear();
            textBoxComment.Text = string.Empty;
            textBoxMarkValue.Text = string.Empty;
            buttonSubmit.Enabled = false;
            buttonDelete.Enabled = false;
        }
    }
}
