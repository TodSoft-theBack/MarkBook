using Business.ViewModels;
using Interface.CustomControls;
using Services.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Interface
{
    class DrawingFunctions
    {
        public static int GetAlphaFromPercent(int percent) => 255 - (percent * 255) / 100;
        private static void DrawCell(Control container, TableCell cell, Control header, int index)
        {
            int offset = (int)cell.BorderThickness;
            cell.Size = header.Size;
            cell.Location = new Point(header.Location.X -40,  (index -1)* (header.Height - offset));
            cell.Name = header.Name + "_" + index;
            SetHover(cell);
            if (!cell.ShowText)
            {
                decimal[] marks = new decimal[0];
                try
                {
                    marks = cell.DisplayText.Split().Select(decimal.Parse).ToArray();
                }
                catch { }
                int space = 10;
                for (int i = 0; i < marks.Length; i++)
                {
                    ContainerCircularFlatButton mark = new ContainerCircularFlatButton
                    {
                        FillColor = Color.Lime,
                        ForeColor = Color.Black,
                        Size = new Size(30, 30)
                    };
                    SetHover(mark);
                    mark.Location = GetLocation(cell, mark, space, i);
                    mark.DisplayText = Math.Round(marks[i]).ToString();
                    cell.Controls.Add(mark);
                }
            }
            container.Controls.Add(cell);
        }
        public static List<decimal> GetMarks(ICollection<Marks> Marks)
        {
            List<decimal> output = new List<decimal>();
            foreach (var mark in Marks)
            {
                output.Add(mark.MarkValue);
            }
            return output;
        }
        public static void DrawTable(Control container, StudentViewModel student, Control SubjectHeader, Control MarkHeader)
        {
            TableCell[,] table = new TableCell[student.Data.Count, 2];
            for (int i = 0; i < student.Data.Count; i++)
            {
                var item = student.Data.ElementAt(i);
                table[i, 0] = new TableCell
                (
                    Color.Black,
                    Color.FromArgb(GetAlphaFromPercent(20), Color.SkyBlue), 3,
                    item.Key.SubjectTitle
                );
                table[i, 1] = new TableCell
                (
                    Color.Black, 
                    Color.Transparent, 3,
                    string.Join(" ", GetMarks(item.Value)));
                table[i, 1].ShowText = false;
                DrawCell(container, table[i, 0], SubjectHeader, i + 1);
                DrawCell(container, table[i, 1], MarkHeader, i + 1);
            }
        }
        public static void DrawTable(Control parent, TeacherViewModel teacherView, Control SubjectHeader, Control MarkHeader)
        {
            TableCell[,] table = new TableCell[teacherView.Data.Count, 2];
            for (int i = 0; i < teacherView.Data.Count; i++)
            {
                var item = teacherView.Data.ElementAt(i);
                table[i, 0] = new TableCell
                (
                    Color.Black,
                    Color.FromArgb(GetAlphaFromPercent(20),Color.SkyBlue),
                    3,
                    string.Format($"{item.Key.FirstName} {item.Key.LastName}")
                );
                table[i, 1] = new TableCell(Color.Black, Color.Transparent, 3, string.Join(" ", GetMarks(item.Value)));
                table[i, 1].ShowText = false;
                DrawCell(parent, table[i, 0], SubjectHeader, i + 1);
                DrawCell(parent, table[i, 1], MarkHeader, i + 1);
            }
        }
        public static void DisposeTable(Control container)
        {
            while (container.Controls.Count > 0)
                container.Controls.RemoveAt(0);
        }
        public static void SetHover(params Control[] hoverable)
        {
            foreach (var control in hoverable)
            {
                control.MouseHover += SelectedControl_MouseHover;
                control.MouseLeave += SelectedControl_MouseLeave;
            }
        }
        private static void SelectedControl_MouseHover(object sender, EventArgs e)
        {
            try
            {
                ((CircularFlatButton)sender).FillColor = Color.FromArgb(GetAlphaFromPercent(50), ((CircularFlatButton)sender).FillColor);
            }
            catch { }
            try
            {

            }
            catch { }
            ((Control)sender).Invalidate();
        }

        private static void SelectedControl_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                ((CircularFlatButton)sender).FillColor = Color.FromArgb(GetAlphaFromPercent(0), ((CircularFlatButton)sender).FillColor);
            }
            catch { }
            try
            {

            }
            catch { }
            ((Control)sender).Invalidate();
        }
        private static Point GetLocation(TableCell parent, CustomControls.CircularFlatButton button, int space, int index)
                => new Point(space + index * (button.Width + space), parent.Height / 2 - button.Height / 2);
    }
}
