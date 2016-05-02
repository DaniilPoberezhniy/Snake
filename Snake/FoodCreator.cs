using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class FoodCreator
    {
        int fildLength;
        int fildHeight;
        char symb;

        Random random = new Random();

        public FoodCreator(int fildLength, int fildHeight, char symb)
        {
            this.fildLength = fildLength;
            this.fildHeight = fildHeight;
            this.symb = symb;
        }

        public Point CreateFood()
        {
            int x = random.Next(2, fildLength - 5);
            int y = random.Next(3, fildHeight - 3);
            return new Point(x, y, symb);
        }
    }
}
