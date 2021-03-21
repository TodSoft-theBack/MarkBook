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
        public Color FillColor  { get; set; }
        public MarkToolTip HoverToolTip;
        public MarkedCircularFlatButton(): base() 
        {

        }
        public void Mark_Hover(object sender, EventArgs e)
        {

        }
        public void Mark_Leave(object sender, EventArgs e)
        {
            CircularFlatButton button = (CircularFlatButton)sender;
            button.FillColor = Color.Lime;
            button.Invalidate();
        }

    }
}
