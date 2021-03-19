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
        public void DrawTable(Dictionary<string, ICollection<object>> Data, Control SubjectHeader, Control MarkHeader)
        {
            TableCell[,] table = new TableCell[Data.Count, 2];
            for (int i = 0; i < Data.Count; i++)
            {
                var item = Data.ElementAt(i);
                table[i, 0] = new TableCell(Color.Black, Color.FromArgb(DrawingFunctions.GetAlphaFromPercent(20), Color.SkyBlue), 3, item.Key);
                table[i, 1] = new TableCell(Color.Black, Color.Transparent, 3, string.Join(" ", item.Value));
                table[i, 1].ShowText = false;
                DrawCell(table[i, 0], SubjectHeader, i + 1);
                DrawCell(table[i, 1], MarkHeader, i + 1);
            }
        }
        private void DrawCell(TableCell cell, Control header, int index)
        {
            int offset = cell.BorderThickness;
            cell.Size = header.Size;
            cell.Location = new Point(header.Location.X, (header.Location.Y + offset) + index * (header.Height - offset));
            if (!cell.ShowText)
            {
                var marks = cell.DisplayText.Split().Select(double.Parse).ToArray();
                int space = 10;
                for (int i = 0; i < marks.Length; i++)
                {
                    CircularFlatButton mark = new CircularFlatButton();
                    mark.FillColor = Color.Lime;
                    mark.ForeColor = Color.White;
                    mark.Size = new Size(30, 30);
                    mark.Location = GetLocation(cell, mark, space, i);
                    mark.DisplayText = marks[i].ToString();
                    mark.MouseHover += Mark_Hover;
                    mark.MouseLeave += Mark_Leave;
                    mark.Parent = cell;
                    cell.Controls.Add(mark);
                }
            }
            this.Controls.Add(cell);
        }
        private void Mark_Hover(object sender, EventArgs e)
        {
            markToolTipConcept.Visible = true;
            CircularFlatButton button = (CircularFlatButton)sender;
            //markToolTipConcept.Location = new Point(button.Location.X + button.Parent.Location.X + 20, button.Location.Y+ button.Parent.Location.Y + 20);
            button.FillColor = Color.FromArgb(128, Color.Black);
            button.Invalidate();
        }
        private void Mark_Leave(object sender, EventArgs e)
        {
            markToolTipConcept.Visible = false;
            CircularFlatButton button = (CircularFlatButton)sender;
            button.FillColor = Color.Lime;
            button.Invalidate();
        }
        private static Point GetLocation(TableCell parent, CircularFlatButton button, int space, int index)
        {
            return new Point(space + index * (button.Width + space), parent.Height / 2 - button.Height / 2);
        }
        private void closeButton_Click(object sender, EventArgs e)
            => this.Close();
        private void TeacherView_Load(object sender, EventArgs e)
        {
            labelFormText.Text = this.Text;
            NavBar.BackColor = Color.FromArgb(DrawingFunctions.GetAlphaFromPercent(30), NavBar.BackColor);
            studentsHeader.BackColor = Color.FromArgb(DrawingFunctions.GetAlphaFromPercent(30), studentsHeader.BackColor);
            marksHeader.BackColor = Color.FromArgb(DrawingFunctions.GetAlphaFromPercent(30), marksHeader.BackColor);
            DrawTable(marks, studentsHeader, marksHeader);
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
