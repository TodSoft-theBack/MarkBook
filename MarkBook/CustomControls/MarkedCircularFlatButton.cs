using MarkBook;
using System;
using System.Collections.Generic;
using System.Text;
using Services;
using Services.Models;
using System.Drawing;
using Services.DAO;

namespace Interface.CustomControls
{
    class MarkedCircularFlatButton:CircularFlatButton
    {
        public Marks Mark { get; set; }
        public MarkToolTip HoverToolTip;
        public MarkedCircularFlatButton(): base() 
        {
            this.MouseHover += Mark_Hover;
            this.MouseLeave += Mark_Leave;
            this.HoverToolTip = new MarkToolTip();
        }
        public void Mark_Hover(object sender, EventArgs e)
        {
            this.HoverToolTip.Visible = true;
            this.FillColor = Color.FromArgb(DrawingFunctions.GetAlphaFromPercent(50), this.FillColor);
        }
        public void Mark_Leave(object sender, EventArgs e)
        {
            this.HoverToolTip.Visible = true;
            this.FillColor = Color.FromArgb(DrawingFunctions.GetAlphaFromPercent(100), this.FillColor);
        }
    }
}
