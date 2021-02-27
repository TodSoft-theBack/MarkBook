using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace MarkBook
{
    class CircularFlatButton : Label
    {
        public Color FillColor { get; set; }
        public CircularFlatButton() : base()
        {
            this.BackColor = Color.Transparent;
            this.Text = string.Empty;
            this.AutoSize = false;
            this.FillColor = Color.Red;
            this.Paint += Button_Paint;
            this.ResizeRedraw = true;
        }
        public CircularFlatButton(Color fillColor, int width, Point location) : this()
        {
            this.FillColor = fillColor;
            this.Location = location;
            this.Size = new Size(width, width);
        }
        public void Button_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            e.Graphics.FillEllipse
            (
                new SolidBrush(this.FillColor),
                this.ClientRectangle
            );
            TextRenderer.DrawText
            (
                e.Graphics,
                this.Text,
                this.Font,
                this.ClientRectangle,
                this.ForeColor
            );
        }
    }
}
