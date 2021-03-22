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
        public static Color MakeTranslucent(int percent,  Color color)
        =>  Color.FromArgb(DrawingFunctions.GetAlphaFromPercent(percent), color);
        private static void DrawCell(Form parent, TableCell cell, Control header, int index)
        {
            int offset = cell.BorderThickness;
            cell.Size = header.Size;
            cell.Location = new Point(header.Location.X, (header.Location.Y + offset) + index * (header.Height - offset));
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
                    CircularFlatButton mark = new CircularFlatButton
                    {
                        FillColor = Color.Lime,
                        ForeColor = Color.White,
                        Size = new Size(30, 30)
                    };
                    mark.Location = GetLocation(cell, mark, space, i);
                    mark.DisplayText = Math.Round(marks[i]).ToString();
                    mark.Parent = cell;
                    cell.Controls.Add(mark);
                }
            }
            parent.Controls.Add(cell);
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
        public static void DrawTable(Form parent, StudentViewModel student, Control SubjectHeader, Control MarkHeader)
        {
            TableCell[,] table = new TableCell[student.Data.Count, 2];
            for (int i = 0; i < student.Data.Count; i++)
            {
                var item = student.Data.ElementAt(i);
                table[i, 0] = new TableCell(Color.Black, Color.FromArgb(GetAlphaFromPercent(20), Color.SkyBlue), 3, item.Key.SubjectTitle);
                table[i, 1] = new TableCell(Color.Black, Color.Transparent, 3, string.Join(" ", GetMarks(item.Value)));
                table[i, 1].ShowText = false;
                DrawCell(parent, table[i, 0], SubjectHeader, i + 1);
                DrawCell(parent, table[i, 1], MarkHeader, i + 1);
            }
        }
        public static void DrawTable(Form parent, TeacherViewModel teacher, Control SubjectHeader, Control MarkHeader)
        {
            TableCell[,] table = new TableCell[teacher.Data.Count, 2];
            for (int i = 0; i < teacher.Data.Count; i++)
            {
                var item = teacher.Data.ElementAt(i);
                table[i, 0] = new TableCell
                (
                    Color.Black,
                    Color.FromArgb(GetAlphaFromPercent(20),
                    Color.SkyBlue), 3,
                    string.Format($"{item.Key.FirstName} {item.Key.LastName}")
                );
                table[i, 1] = new TableCell(Color.Black, Color.Transparent, 3, string.Join(" ", GetMarks(item.Value)));
                table[i, 1].ShowText = false;
                DrawCell(parent, table[i, 0], SubjectHeader, i + 1);
                DrawCell(parent, table[i, 1], MarkHeader, i + 1);
            }
        }
        private static Point GetLocation(TableCell parent, CircularFlatButton button, int space, int index)
                => new Point(space + index * (button.Width + space), parent.Height / 2 - button.Height / 2); 
    }
}
