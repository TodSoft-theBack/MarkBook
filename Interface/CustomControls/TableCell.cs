using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Interface.CustomControls
{
    public enum TextFormats
    {
        Center,
        Left,
        Right
    }
    class TableCell : Panel
    {
        private readonly Pen border;
        public bool ShowText { get; set; }
        public Color FillColor { get { return this.BackColor; } set { this.BackColor = value; } }
        public Color BorderColor { get; set; }
        public int BorderThickness { get; set; }
        public string DisplayText { get; set; }
        public bool HasBorder { get; set; } = true;
        public TextFormats TextFormat { get; set; }
        public TableCell() : base()
        {
            this.DisplayText = this.Name;
            this.BorderThickness = 3;
            this.FillColor = Color.Transparent;
            this.BorderColor = Color.Black;
            this.Paint += Border_Paint;
            this.border = new Pen(this.BorderColor, this.BorderThickness);
            this.ShowText = true;
            this.TextFormat = TextFormats.Center;
        }
        public TableCell(Color borderColor, int thickness) : base()
        {
            this.DisplayText = this.Name;
            this.BorderThickness = thickness;
            this.FillColor = Color.Transparent;
            this.BorderColor = borderColor;
            this.Paint += Border_Paint;
            this.border = new Pen(this.BorderColor, this.BorderThickness);
        }
        public TableCell(Color borderColor, Color fillColor, int thickness) : base()
        {
            this.DisplayText = this.Name;
            this.BorderThickness = thickness;
            this.FillColor = fillColor;
            this.BorderColor = borderColor;
            this.Paint += Border_Paint;
            this.border = new Pen(this.BorderColor, this.BorderThickness);
        }
        public TableCell(Color borderColor, Color fillColor, int thickness, string text) : base()
        {
            this.BorderThickness = thickness;
            this.FillColor = fillColor;
            this.BorderColor = borderColor;
            this.Paint += Border_Paint;
            this.border = new Pen(this.BorderColor, this.BorderThickness);
            this.DisplayText = text;
            this.ShowText = true;
            this.TextFormat = TextFormats.Center;
        }
        private void Border_Paint(object sender, PaintEventArgs e)
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
            if (this.ShowText)
            {
                TextRenderer.DrawText
                    (
                        e.Graphics,
                        this.DisplayText,
                        this.Font,
                        this.ClientRectangle,
                        this.ForeColor,
                        Color.Transparent,
                        GetFlags()
                    );
            }
        }
        private TextFormatFlags GetFlags()
        {
            TextFormatFlags flags = TextFormatFlags.Default;
            switch (this.TextFormat)
            {
                case TextFormats.Center:
                    flags = TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter;
                    break;
                case TextFormats.Right:
                    flags = TextFormatFlags.Right | TextFormatFlags.VerticalCenter;
                    break;
                case TextFormats.Left:
                    flags = TextFormatFlags.Left | TextFormatFlags.VerticalCenter;
                    break;
            }
            return flags;
        }
    }
}
