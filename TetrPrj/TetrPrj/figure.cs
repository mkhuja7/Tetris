using System;
using System.Collections.Generic;
using System.Text;

namespace TetrPrj
{
    class figure
    {
        protected Points[] points = new Points[4];
        public void Draw()
        {
            foreach (Points p in points)
            {
                p.Draw();
            }
        }
    }
}
