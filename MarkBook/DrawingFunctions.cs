using MarkBook;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Services.Models;
using Interface.CustomControls;

namespace Interface
{
    class DrawingFunctions
    {
        public static int GetAlphaFromPercent(int percent) => 255 - (percent * 255) / 100;
        private static void DrawCell(Form parent, TableCell cell, Control header, int index)
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
                    mark.Parent = cell;
                    cell.Controls.Add(mark);
                }
            }
            parent.Controls.Add(cell);
        }
        public static void DrawTable(Form parent, ICollection<Students> students, Control SubjectHeader, Control MarkHeader)
        {
            TableCell[,] table = new TableCell[students.Count, 2];
            for (int i = 0; i < students.Count; i++)
            {
                var item = students.ElementAt(i);
                table[i, 0] = new TableCell(Color.Black, Color.FromArgb(GetAlphaFromPercent(20), Color.SkyBlue), 3, item.FirstName + " " + item.LastName);
                table[i, 1] = new TableCell(Color.Black, Color.Transparent, 3, string.Join(" ", item));
                table[i, 1].ShowText = false;
                DrawCell(parent, table[i, 0], SubjectHeader, i + 1);
                DrawCell(parent, table[i, 1], MarkHeader, i + 1);
            }
        }
        public static void DrawTable(Form parent, ICollection<Subjects> subjects, Control SubjectHeader, Control MarkHeader)
        {
            TableCell[,] table = new TableCell[subjects.Count, 2];
            for (int i = 0; i < subjects.Count; i++)
            {
                var item = subjects.ElementAt(i);
                table[i, 0] = new TableCell(Color.Black, Color.FromArgb(GetAlphaFromPercent(20), Color.SkyBlue), 3, item.SubjectTitle);
                table[i, 1] = new TableCell(Color.Black, Color.Transparent, 3, string.Join(" ", item));
                table[i, 1].ShowText = false;
                DrawCell(parent, table[i, 0], SubjectHeader, i + 1);
                DrawCell(parent, table[i, 1], MarkHeader, i + 1);
            }
        }
        private static void DrawCell(Form parent, TableCell cell, Marks mark, Control header, int index)
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
                    MarkedCircularFlatButton markButton = new MarkedCircularFlatButton();
                    markButton.FillColor = Color.Lime;
                    markButton.ForeColor = Color.White;
                    markButton.Size = new Size(30, 30);
                    markButton.Location = GetLocation(cell, markButton, space, i);
                    markButton.DisplayText = marks[i].ToString();
                    markButton.Parent = cell;
                    cell.Controls.Add(markButton);
                }
            }
            parent.Controls.Add(cell);
        }
        private static Point GetLocation(TableCell parent, CircularFlatButton button, int space, int index)
                => new Point(space + index * (button.Width + space), parent.Height / 2 - button.Height / 2); 
    }
}
