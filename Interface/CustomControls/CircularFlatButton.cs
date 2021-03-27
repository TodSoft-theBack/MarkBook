using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Interface.CustomControls
{
    class CircularFlatButton : Label
    {
        public Color FillColor { get; set; }
        public string DisplayText { get; set; }
        public CircularFlatButton() : base()
        {
            this.BackColor = Color.Transparent;
            this.DisplayText = string.Empty;
            this.AutoSize = false;
            this.FillColor = Color.Red;
            this.Paint += Button_Paint;
            this.ResizeRedraw = true;
            this.Padding = new Padding(1);
        }
        public CircularFlatButton(Color fillColor, int width, Point location) : this()
        {
            this.FillColor = fillColor;
            this.Location = location;
            this.Size = new Size(width, width);
            this.Padding = new Padding(1);
        }
        public void Button_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            e.Graphics.FillEllipse
            (
                new SolidBrush(this.FillColor),
                new Rectangle
                (
                    new Point
                    (
                        this.Padding.Left,
                        this.Padding.Top
                    ),
                    new Size
                    (
                        this.Width - 2*this.Padding.Right,
                        this.Height - 2*this.Padding.Bottom
                    )
                )
            );
            if (!string.IsNullOrEmpty(this.DisplayText))
            {
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
}
