using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(82, 27);
            
            //Отрисовка рамочки.
            HorisontalLine lowLine = new HorisontalLine(1, 78, 25, '=');
            HorisontalLine topLine = new HorisontalLine(1, 78, 2, '=');
            VerticalLine leftLine = new VerticalLine(1, 3, 24, '|');
            VerticalLine rightLine = new VerticalLine(78, 3, 24, '|');
            lowLine.DrawLine();
            topLine.DrawLine();
            leftLine.DrawLine();
            rightLine.DrawLine();

            //Отрисовка еды.
            FoodCreator foodCreator = new FoodCreator(82, 27, '@');
            Point food = foodCreator.CreateFood();
            food.Draw();

            //Отрисовка змейки.
            Point startPoint = new Point(3,4,'*');
            Snake snake = new Snake(startPoint, 4, Direction.RIGHT);
            snake.DrawLine();
            
            while(true)
            {
                if(snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }
                Thread.Sleep(100);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.Control(key.Key);
                }
                //Thread.Sleep(100);
                //snake.Move();
            }

           

            Console.ReadLine();
        }

        
    }
}
