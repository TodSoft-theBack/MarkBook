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
        public static bool ReadOnly = false;
        public static int GetAlphaFromPercent(int percent) => 255 - (percent * 255) / 100;
        private static void DrawCell(Control container, TableCell cell, Control header, int index, bool setHover)
        {
            int offset = (int)cell.BorderThickness;
            cell.Size = header.Size;
            cell.Location = new Point(header.Location.X - 40, (index) * (header.Height - offset));
            cell.Name = header.Name + "_" + index;
            if (setHover) SetHover(cell);
            if (!cell.ShowText)
            {
                decimal[] marks = new decimal[0];
                try
                {
                    marks = cell.DisplayText.Split().Select(decimal.Parse).ToArray();
                }
                catch { }
                for (int i = 0; i < marks.Length; i++)
                {
                    CircularFlatButton mark = new CircularFlatButton()
                    {
                        FillColor = Color.Lime,
                        ForeColor = Color.Black,
                        Size = new Size(30, 30)
                    };
                    mark.ContainsDataInfo = true;
                    mark.Key = new int[]
                    {
                        (cell.Key.Length > 0)?cell.Key[0]:-1,
                        i
                    };
                    SetHover(mark);
                    mark.Location = GetLocation(cell, mark, 10, i);
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
        public static void DrawTable(Control container, IViewModel student, Control SubjectHeader, Control MarkHeader)
        {
            TableCell[,] table = new TableCell[student.Count, 2];
            for (int i = 0; i < student.Count; i++)
            {
                table[i, 0] = new TableCell
                (
                    Color.Black,
                    Color.FromArgb(GetAlphaFromPercent(20), Color.SkyBlue), 3,
                    student.Title[i]
                );
                table[i, 0].Key = new int[] { i, 0 };
                table[i, 0].ContainsDataInfo = true;
                table[i, 1] = new TableCell
                (
                    Color.Black,
                    Color.Transparent, 3,
                    (i >= 0 && i < student.Marks.Count) ? string.Join(" ", student.Marks[i]) : string.Empty
                );
                table[i, 1].Key = new int[] { i, 1 };
                table[i, 1].ContainsDataInfo = true;
                table[i, 1].ShowText = false;
                DrawCell(container, table[i, 0], SubjectHeader, i, true);
                DrawCell(container, table[i, 1], MarkHeader, i, false);
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
                ((TableCell)sender).FillColor = Color.FromArgb(GetAlphaFromPercent(0), ((TableCell)sender).FillColor);
            }
            catch { }
            ((Control)sender).Invalidate();
        }

        private static void SelectedControl_MouseLeave(object sender, EventArgs e)
        {
            if (ReadOnly)
            {
                try
                {
                    ((CircularFlatButton)sender).FillColor =
                    Color.FromArgb
                    (
                        GetAlphaFromPercent(0),
                        ((CircularFlatButton)sender).FillColor
                    );
                }
                catch { }
                try
                {
                    ((TableCell)sender).FillColor =
                    Color.FromArgb
                    (
                        GetAlphaFromPercent(30),
                        ((TableCell)sender).FillColor
                    );
                }
                catch { }
            }
            else
            {
                try
                {
                    if (!((CircularFlatButton)sender).Selected)
                    {
                        ((CircularFlatButton)sender).FillColor =
                        Color.FromArgb
                        (
                            GetAlphaFromPercent(0),
                            ((CircularFlatButton)sender).FillColor
                        );
                    }
                }
                catch { }
                try
                {
                    if (!((TableCell)sender).Selected)
                    {
                        ((TableCell)sender).FillColor =
                        Color.FromArgb
                        (
                            GetAlphaFromPercent(30),
                            ((TableCell)sender).FillColor
                        );
                    }
                }
                catch { }
            }
            ((Control)sender).Invalidate();
        }
        private static Point GetLocation(TableCell parent, CircularFlatButton button, int offset, int index)
                => new Point(offset + index * (button.Width + offset), parent.Height / 2 - button.Height / 2);
    }
}
