﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TetrPrj
{
    class Stick : figure
    {

        public Stick(int x, int y, char s)
        {
            points[0] = new Points(x, y, s);
            points[1] = new Points(x, y+1, s);
            points[2] = new Points(x, y+2, s);
            points[3] = new Points(x, y+3, s);

        }


    }
}
