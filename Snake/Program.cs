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
            VerticalLine vl = new VerticalLine(5, 6, 16, '^');
            Draw(vl);

            Point p = new Point(7, 6, '*');
            Figure fSnake = new Snake(p, 5, Direction.RIGHT);
            Draw(fSnake);
            //Snake snake = (Snake)fSnake;

            HorisontalLine hl = new HorisontalLine(4, 15, 7, ')');

            List<Figure> figures = new List<Figure>();
            figures.Add(vl);
            figures.Add(hl);
            figures.Add(fSnake);
            
            foreach(var f in figures)
            {
                f.DrawLine();
            } 


            Console.ReadLine();
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
            //Console.ReadLine();
        }

        static void Draw(Figure figure)
        {
            figure.DrawLine();
        }

        
    }
}
