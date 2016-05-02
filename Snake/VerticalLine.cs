﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLine : Figure
    {
        public VerticalLine(int x, int yLow, int yTop, char symb)
        {
            line = new List<Point>();
            for (int y = yLow; y <= yTop; y++)
            {
                Point p = new Point(x, y, symb);
                line.Add(p);
            }
        }
    }
}
