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
using Business.ViewModels;
using Interface.AddDialogs;
using Interface.CustomControls;

namespace Interface
{
    public partial class TeacherView : Form
    {
        public TeacherView()
        {
            InitializeComponent();
        }
        Teachers teacher;
        public TeacherController teacherController;
        ICollection<Subjects> Subjects;
        TeacherViewModel teacherData = new TeacherViewModel();
        MarkBookDBContext Database;
        private void CloseButton_Click(object sender, EventArgs e)
            => this.Close();
        private void minimizeButton_Click(object sender, EventArgs e)
            => this.WindowState = FormWindowState.Minimized;
        public static string SubjectToString(Subjects subject)
            => string.Format($"{subject.SubjectTitle} (Grade: {subject.Grade.GradeNumber}{subject.Grade.GradeForm})");
        private void TeacherView_Load(object sender, EventArgs e)
        {
            teacher = (Teachers)((LogInForm)this.Owner).LogInInfo;
            Database = ((LogInForm)this.Owner).Database;
            teacherController = new TeacherController(Database);
            labelFormText.Text = string.Format($"MarkBook(Teacher) - {teacher.FirstName} {teacher.LastName}");
            comboBoxGrade.Items.Clear();
            this.Subjects = teacherController.GetSubjects(teacher.TeacherId);
            foreach (var subject in this.Subjects.Select(s => SubjectToString(s)))
                comboBoxGrade.Items.Add(subject);
            NavBar.BackColor = Color.FromArgb(DrawingFunctions.GetAlphaFromPercent(30), NavBar.BackColor);
            studentsHeader.FillColor = Color.FromArgb(DrawingFunctions.GetAlphaFromPercent(30), studentsHeader.FillColor);
            marksHeader.FillColor = Color.FromArgb(DrawingFunctions.GetAlphaFromPercent(30), marksHeader.FillColor);
            gradeHeader.FillColor = Color.FromArgb(DrawingFunctions.GetAlphaFromPercent(30), gradeHeader.FillColor);
            DrawingFunctions.SetHover(minimizeButton, closeButton, buttonAddMark,buttonDeleteMark);
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
            DrawingFunctions.DisposeTable(tableContainer);
            if (comboBoxGrade.SelectedIndex >= 0 && comboBoxGrade.SelectedIndex < this.Subjects.Count) 
            {
                teacherData = teacherController.GetTeacherData(teacher.TeacherId, Subjects.ElementAt(comboBoxGrade.SelectedIndex).SubjectId);
                DrawingFunctions.DrawTable(tableContainer,teacherData , studentsHeader, marksHeader);
            }
        }
        private static List<TableCell> GetConvinientCollection(Control.ControlCollection list)
        {
            List<TableCell> output = new List<TableCell>();
            foreach (var item in list)
                output.Add((TableCell)item);
            return output;
        }
        private void buttonAddMark_Click(object sender, EventArgs e)
        {
            var selectedStudents = GetConvinientCollection(tableContainer.Controls).Where(p => ((IHoverDataContainer)p).Selected).ToList();
            if (selectedStudents.Count < 1)
            {
                MessageBox.Show("You have not selected anything!\nPlease, select studets to assign a mark to!", "Empty selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            List<Students> students = new List<Students>();
            foreach (var selectedStudent in selectedStudents)
            {
                students.Add(teacherData.Data.ElementAt(selectedStudent.Key[0]).Key);
            }
            using(AddMarkDialog addDialog = new AddMarkDialog())
            {
                this.Hide();
                addDialog.Owner = this;
                addDialog.subject = Subjects.ElementAt(comboBoxGrade.SelectedIndex);
                addDialog.students = students;
                addDialog.ShowDialog();
                this.Show();
            }
            comboBoxGrade_SelectedIndexChanged(new object(), new EventArgs());
        }
        private List<CircularFlatButton> GetMarksCollection()
        {
            List<CircularFlatButton> markContainers = new List<CircularFlatButton>();
            foreach (var cell in GetConvinientCollection(tableContainer.Controls))
            {
                if (cell.Key[1] == 1)
                    foreach (var item in cell.Controls)
                    {
                        if(((CircularFlatButton)item).Selected)
                        markContainers.Add((CircularFlatButton)item);
                    }
                    
            }
            return markContainers;
        }
        private void buttonDeleteMark_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Are you sure you want to delete those marks?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                case DialogResult.Yes:
                var selectedMarks = GetMarksCollection();
                foreach (var markContainer in selectedMarks)
                {
                    var selectedStudent = teacherData.Data.ElementAt(markContainer.Key[0]).Key;
                    var mark = teacherData.Data[selectedStudent].ElementAt(markContainer.Key[1]);
                    teacherController.RemoveMarkById(mark.MarkId);
                }
                break;
            }
            comboBoxGrade_SelectedIndexChanged(new object(), new EventArgs());
        }
    }
}
