using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(5,7,'@');
            p1.Draw();

            HorisontalLine line = new HorisontalLine(1, 10, 7, '*');
            line.DrawLine();

            Console.ReadLine();
        }

        
    }
}
