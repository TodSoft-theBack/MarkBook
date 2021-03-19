using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    class DrawingFunctions
    {
        public static int GetAlphaFromPercent(int percent) => 255 - (percent * 255) / 100;

    }
}
