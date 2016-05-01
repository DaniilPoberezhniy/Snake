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
            int x1 = 6;
            int y1 = 8;
            char symb1 = '*';
            Draw(x1,y1,symb1);

            Console.ReadLine();
        }

        static void Draw(int x, int y, char symb)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(symb);
        }
    }
}
