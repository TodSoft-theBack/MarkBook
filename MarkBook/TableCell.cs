using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MarkBook
{
    class TableCell : Panel
    {
        private Pen border;
        public Color FillColor { get; set; }
        public Color BorderColor { get; set; }
        public int BorderThickness { get; set; }
        public string DisplayText { get; set; }
        public bool HasBorder { get; set; } = true;
        public TableCell() : base()
        {
            this.DisplayText = this.Name;
            this.BorderThickness = 3;
            this.FillColor = Color.Transparent;
            this.BorderColor = Color.Black;
            this.Paint += border_Paint;
            this.BackColor = this.FillColor;
            this.border = new Pen(this.BorderColor, this.BorderThickness);
        }
        public TableCell(Color borderColor, int thickness) : base()
        {
            this.DisplayText = this.Name;
            this.BorderThickness = thickness;
            this.FillColor = Color.Transparent;
            this.BorderColor = borderColor;
            this.Paint += border_Paint;
            this.BackColor = this.FillColor;
            this.border = new Pen(this.BorderColor, this.BorderThickness);
        }
        public TableCell(Color borderColor, Color fillColor, int thickness) : base()
        {
            this.DisplayText = this.Name;
            this.BorderThickness = thickness;
            this.FillColor = fillColor;
            this.BorderColor = borderColor;
            this.Paint += border_Paint;
            this.BackColor = this.FillColor;
            this.border = new Pen(this.BorderColor, this.BorderThickness);
        }
        public TableCell(Color borderColor, Color fillColor, int thickness, string text) : base()
        {
            this.BorderThickness = thickness;
            this.FillColor = fillColor;
            this.BorderColor = borderColor;
            this.Paint += border_Paint;
            this.BackColor = this.FillColor;
            this.border = new Pen(this.BorderColor, this.BorderThickness);
            this.DisplayText = text;
        }
        private void border_Paint(object sender, PaintEventArgs e)
        {
            if (this.HasBorder)
            {
                e.Graphics.DrawRectangle
                    (
                        this.border,
                        new Rectangle
                        (
                            (int)this.border.Width / 2,
                            (int)this.border.Width / 2,
                            this.ClientSize.Width - (int)this.border.Width,
                            this.ClientSize.Height - (int)this.border.Width
                        )
                    ); 
            }
            TextRenderer.DrawText
            (
                e.Graphics,
                this.DisplayText,
                this.Font,
                this.ClientRectangle,
                this.ForeColor
            );
        }
    }
}
