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
    public partial class StudentView : Form
    {
        public StudentView()
        {
            InitializeComponent();
        }
        Dictionary<string, ICollection<object>> marks = new Dictionary<string, ICollection<object>>()
        {
            ["Български език"] = new List<object> { 6, 5, 6, 3 },
            ["Английски език"] = new List<object> { 6, 5, 6, 3 },
            ["Руски език"] = new List<object> { 6, 5, 6, 6 }
        };
        public void DrawTable(Dictionary<string, ICollection<object>> Data, Control SubjectHeader, Control MarkHeader)
        {
            TableCell[,]  table = new TableCell[Data.Count,2];
            for (int i = 0; i < Data.Count; i++)
            {
                var item = Data.ElementAt(i);
                table[i, 0] = new TableCell(Color.Black, Color.FromArgb(50, Color.Blue), 3, item.Key);
                table[i, 1] = new TableCell(Color.Black, Color.Transparent, 3, string.Join(" ", item.Value));
                table[i, 1].ShowText = false;
                DrawCell(table[i, 0], SubjectHeader, i+1);
                DrawCell(table[i, 1], MarkHeader, i+1);
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
                    mark.FillColor = Color.YellowGreen;
                    mark.ForeColor = Color.White;
                    mark.Size = new Size(30, 30);
                    mark.Location = GetLocation(cell, mark, space, i);
                    mark.DisplayText = marks[i].ToString();
                    mark.MouseHover += Mark_Hover;
                    mark.MouseLeave += Mark_Leave;
                    cell.Controls.Add(mark);
                }
            }
            this.Controls.Add(cell);
        }
        private void Mark_Hover(object sender, EventArgs e)
        {
            markToolTipConcept.Visible = true;
        }
        private void Mark_Leave(object sender, EventArgs e)
        {
            markToolTipConcept.Visible = false;
        }
        private Point GetLocation(TableCell parent,CircularFlatButton button,int space, int index)
        {
            return new Point(space + index * (button.Width + space), parent.Height / 2 - button.Height / 2);
        }

        private void StudentView_Load(object sender, EventArgs e)
        {
            labelFormText.Text = this.Text;
            NavBar.BackColor = Color.FromArgb(LogInForm.GetAlphaFromPercent(30), NavBar.BackColor);
            subjectsHeader.BackColor = Color.FromArgb(LogInForm.GetAlphaFromPercent(30), subjectsHeader.BackColor);
            marksHeader.BackColor = Color.FromArgb(LogInForm.GetAlphaFromPercent(30), marksHeader.BackColor);
            this.DrawTable(marks, subjectsHeader, marksHeader);
        }
        private void StudentView_TextChanged(object sender, EventArgs e)
            => labelFormText.Text = this.Text;
        private void closeButton_Click(object sender, EventArgs e)
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
            {
                this.Location = new Point(this.Location.X - firstLocation.X + e.X, this.Location.Y - firstLocation.Y + e.Y);
            }
        }
    }
}
