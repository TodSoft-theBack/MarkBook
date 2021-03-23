﻿using System;
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
        public Color FillColor { get; set; }
        public Color BorderColor { get { return this.border.Color; } set { this.border.Color = value; } }
        public float BorderThickness { get { return this.border.Width; } set { this.border.Width = value; } }
        public string DisplayText { get; set; }
        public bool HasBorder { get; set; } = true;
        public TextFormats TextFormat { get; set; }
        public TableCell() : base()
        {
            this.DisplayText = this.Name;
            this.ShowText = true;
            this.FillColor = Color.Transparent;
            this.BackColor = Color.Transparent;
            this.border = new Pen(Color.Black, 3);
            this.TextFormat = TextFormats.Center;
            this.Paint += Border_Paint;
        }
        public TableCell(Color borderColor, int thickness) : base()
        {
            this.DisplayText = this.Name;
            this.ShowText = true;
            this.FillColor = Color.Transparent;
            this.BackColor = Color.Transparent;
            this.border = new Pen(borderColor, thickness);
            this.TextFormat = TextFormats.Center;
            this.Paint += Border_Paint;
        }
        public TableCell(Color borderColor, Color fillColor, int thickness) : base()
        {
            this.DisplayText = this.Name;
            this.ShowText = true;
            this.FillColor = fillColor;
            this.BackColor = Color.Transparent;
            this.border = new Pen(borderColor, thickness);
            this.TextFormat = TextFormats.Center;
            this.Paint += Border_Paint;
        }
        public TableCell(Color borderColor, Color fillColor, int thickness, string text) : base()
        {
            this.DisplayText = text;
            this.ShowText = true;
            this.FillColor = fillColor;
            this.BackColor = Color.Transparent;
            this.border = new Pen(borderColor, thickness);
            this.TextFormat = TextFormats.Center;
            this.Paint += Border_Paint;
        }
        private void Border_Paint(object sender, PaintEventArgs e)
        {
            if(this.FillColor != Color.Transparent)
            {
                e.Graphics.FillRectangle
                (
                    new SolidBrush(this.FillColor),
                    this.ClientRectangle
                );
            }
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
