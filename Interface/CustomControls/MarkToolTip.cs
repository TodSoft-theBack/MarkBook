using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Interface.CustomControls
{
    public class MarkToolTip:Panel
    {
        private float thickness;
        private int radius;
        public float BorderThickness
        {
            get { return thickness; }
            set
            {
                if (value <= 0) throw new Exception("Border thickness cannot be zero or less!!!");
                thickness = value;
            }
        }
        public int BorderRadius
        {
            get { return radius; }
            set
            {
                if (value < 0) throw new Exception("Border radius cannot be zero or less!!!");
                radius = value;
            }
        }

        public bool CssMode { get; set; }
        public Color FillColor { get; set; }
        public Color BorderColor { get; set; }
        public string DisplayText { get; set; }

        public MarkToolTip() : base()
        {
            this.Paint += ToolTip_Paint;
            this.BackColor = Color.Transparent;
            this.FillColor = Color.White;
            this.BorderColor = Color.DarkBlue;
            this.BorderRadius = 50;
            this.BorderThickness = 3;
            this.DisplayText = this.Name;
        }
        private void ToolTip_Paint(object sender, PaintEventArgs e)
        {

            Graphics g = e.Graphics;
            GraphicsPath graphicsPath = GetPath(this.ClientRectangle);
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.FillPath(new SolidBrush(this.FillColor), graphicsPath);
            g.DrawPath(new Pen(this.BorderColor, this.BorderThickness), graphicsPath);
            if (!string.IsNullOrEmpty(this.DisplayText))
                TextRenderer.DrawText(g, this.DisplayText, this.Font, this.ClientRectangle, this.ForeColor);
        }

        private GraphicsPath GetPath(Rectangle rectangle)
        {
            GraphicsPath path = new GraphicsPath();
            if (this.BorderRadius == 0)
            {
                path.AddLine(this.BorderThickness,
                             this.BorderThickness,
                             rectangle.Width - this.BorderThickness,
                             this.BorderThickness);
                return path;
            }
            float width, height;
            if (CssMode)
            {
                width = (this.Width * this.BorderRadius) / 100.00f;
                height = (this.Height * this.BorderRadius) / 100.00f;
            }
            else
            {
                width = (Math.Min(this.Width, this.Height) * this.BorderRadius) / 100f;
                height = width;
            }
            width -= 2 * this.BorderThickness;
            height -= 2 * this.BorderThickness;

            /*top left*/
            path.AddArc(rectangle.X + this.BorderThickness,
                        rectangle.Y + this.BorderThickness,
                        width, height, 180, 90);
            /*top right*/
            path.AddArc((rectangle.X + rectangle.Width) - (width + this.BorderThickness),
                         rectangle.Y + this.BorderThickness,
                         width, height, 270, 90);
            /*bottom right*/
            path.AddArc((rectangle.X + rectangle.Width) - (width + this.BorderThickness),
                        (rectangle.Y + rectangle.Height) - (height + this.BorderThickness),
                         width, height, 0, 90);
            /*bottom left*/
            path.AddArc(rectangle.X + this.BorderThickness,
                        rectangle.Y + rectangle.Height - (height + this.BorderThickness),
                        width, height, 90, 90);
            path.CloseAllFigures();
            return path;
        }
    }
}
