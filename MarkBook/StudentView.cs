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
        Dictionary<string, List<double>> marks = new Dictionary<string, List<double>>()
        {
            ["Български език"] = new List<double> { 6, 4, 6, 2 },
            ["pp"] = new List<double> { 6, 4, 6, 2 },
            ["Dosafpms"] = new List<double> { 6, 4, 6, 2 }
        };
        public static void DrawTable( Control[] headers, Dictionary<string, ICollection<object>> Data)
        {
            TableCell[] cellsToDraw;
            foreach (var item in headers)
            {
                cellsToDraw = DrawColumn(item, Data.Count);
            }
        }

        private static TableCell[] DrawColumn(Control header,int count)
        {
            //TableCell[] objects = new TableCell[count];
            throw new NotImplementedException();
        }

        private void StudentView_Load(object sender, EventArgs e)
        {
            labelFormText.Text = this.Text;
            NavBar.BackColor = Color.FromArgb(LogInForm.GetAlphaFromPercent(30), NavBar.BackColor);
            subjectsHeader.BackColor = Color.FromArgb(LogInForm.GetAlphaFromPercent(30), subjectsHeader.BackColor);
            marksHeader.BackColor = Color.FromArgb(LogInForm.GetAlphaFromPercent(30), marksHeader.BackColor);
            int i = 1;
            foreach (var item in marks)
            {
                TableCell subject = new TableCell(Color.Black, Color.Transparent, 3, item.Key);
                subject.Size = subjectsHeader.Size;
                subject.Location = new Point(subjectsHeader.Location.X, (subjectsHeader.Location.Y + subject.BorderThickness) + i * (subjectsHeader.Height - subject.BorderThickness));
                TableCell mark = new TableCell(Color.Black, Color.Transparent, 3, string.Join(", ", item.Value));
                mark.Size = new Size(marksHeader.Width + mark.BorderThickness, marksHeader.Height);
                mark.Location = new Point(marksHeader.Location.X - mark.BorderThickness, (marksHeader.Location.Y + mark.BorderThickness) + i * (marksHeader.Height - subject.BorderThickness));
                this.Controls.Add(subject);
                this.Controls.Add(mark);
                i++;
            }
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
