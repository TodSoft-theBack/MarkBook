using System;
using System.Collections.Generic;
using System.Text;

using System.Drawing;
namespace Interface.CustomControls
{
    class ContainerCircularFlatButton:CircularFlatButton
    {
        //public Marks Mark { get; set; }
        public MarkToolTip HoverToolTip;
        public ContainerCircularFlatButton(): base() 
        {
            this.HoverToolTip = new MarkToolTip();
        }
        public void Container_Hover(object sender, EventArgs e)
        {
            this.HoverToolTip.Visible = true;
            this.FillColor = Color.FromArgb(DrawingFunctions.GetAlphaFromPercent(50), this.FillColor);
        }
        public void Container_Leave(object sender, EventArgs e)
        {
            this.HoverToolTip.Visible = true;
            this.FillColor = Color.FromArgb(DrawingFunctions.GetAlphaFromPercent(100), this.FillColor);
        }
    }
}
