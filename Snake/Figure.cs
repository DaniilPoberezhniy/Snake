using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Figure
    {
        protected List<Point> line;

        public void DrawLine()
        {
            foreach (Point p in line)
            {
                p.Draw();
            }
        }
    }
}
