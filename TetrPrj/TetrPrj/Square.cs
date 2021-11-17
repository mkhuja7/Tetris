using System;
using System.Collections.Generic;
using System.Text;

namespace TetrPrj
{
    class Square
    {
        Points[] points = new Points[4];

        public Square(int x, int y, char s)
        {
            points[0] = new Points(x, y, s);
            points[1] = new Points(x+1, y, s);
            points[2] = new Points(x, y+1, s);
            points[3] = new Points(x+1, y+1, s);

        }

        public void Draw()
        {
            foreach(Points p in points)
            {
                p.Draw();
            }
        }
    }
}
