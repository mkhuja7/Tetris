using System;
using System.Collections.Generic;
using System.Text;

namespace TetrPrj
{
    class Points
    {
        public int x;
        public int y;
        public char c;

        public Points(int a, int b, char s)
        {
            x = a;
            y = b;
            c = s;
        }

        public Points() { }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(c);
        }
    }
}
