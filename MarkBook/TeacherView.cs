using Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        Dictionary<string, ICollection<object>> marks = new Dictionary<string, ICollection<object>>()
        {
            ["Todor"] = new List<object> { 6, 5, 6, 6 },
            ["Petar"] = new List<object> { 6, 5, 6, 3 },
            ["Alexander"] = new List<object> { 6, 5, 6, 6 }
        };
        public void Mark_Hover(object sender, EventArgs e)
        {
            markToolTipConcept.Visible = true;
            CircularFlatButton button = (CircularFlatButton)sender;
            //markToolTipConcept.Location = new Point(button.Location.X + button.Parent.Location.X + 20, button.Location.Y+ button.Parent.Location.Y + 20);
            button.FillColor = Color.FromArgb(128, Color.Black);
            button.Invalidate();
        }
        public void Mark_Leave(object sender, EventArgs e)
        {
            markToolTipConcept.Visible = false;
            CircularFlatButton button = (CircularFlatButton)sender;
            button.FillColor = Color.Lime;
            button.Invalidate();
        }
        private void closeButton_Click(object sender, EventArgs e)
            => this.Close();
        private void TeacherView_Load(object sender, EventArgs e)
        {
            labelFormText.Text = this.Text;
            NavBar.BackColor = Color.FromArgb(DrawingFunctions.GetAlphaFromPercent(30), NavBar.BackColor);
            studentsHeader.BackColor = Color.FromArgb(DrawingFunctions.GetAlphaFromPercent(30), studentsHeader.BackColor);
            marksHeader.BackColor = Color.FromArgb(DrawingFunctions.GetAlphaFromPercent(30), marksHeader.BackColor);
            DrawingFunctions.DrawTable(this, marks, studentsHeader, marksHeader);
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
