using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class HorisontalLine
    {
        List<Point> line;

        public HorisontalLine( int xLeft, int xRight, int y, char symb)
        {
            line = new List<Point>();
            for (int i = xLeft; i <= xRight; i++ )
            {
                Point p = new Point(i, y, symb);
                line.Add(p);
            }
        }

        public void DrawLine()
        {
            foreach (Point p in line)
            {
                p.Draw();
            }
        }
    }
}
