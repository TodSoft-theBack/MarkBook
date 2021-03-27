using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Interface.CustomControls
{
    public class ControlFunctions
    {
        public static TextFormatFlags GetFlags(ContentAlignment alignment)
        {
            TextFormatFlags flags = TextFormatFlags.Default;
            switch (alignment)
            {
                case ContentAlignment.MiddleCenter:
                    flags = TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter;
                    break;
                case ContentAlignment.MiddleRight:
                    flags = TextFormatFlags.Right | TextFormatFlags.VerticalCenter;
                    break;
                case ContentAlignment.MiddleLeft:
                    flags = TextFormatFlags.Left | TextFormatFlags.VerticalCenter;
                    break;
            }
            return flags;
        }
    }
}
