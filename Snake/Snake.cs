using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Figure
    {
        Direction direction;
        public Snake( Point tail, int lenght, Direction _direction)
        {
            direction = _direction;
            line = new List<Point>(); 
            for (int i = 0; i < lenght; i++ )
            {
                Point p = new Point(tail);
                p.Move(i, _direction);
                line.Add(p);
            }
        }

        internal void Move()
        {
            Point tail = line.First();
            line.Remove(tail);
            Point head = GetNextPoint();
            line.Add(head);

            tail.Clear();
            head.Draw();
        }

        public Point GetNextPoint()
        {
            Point head = line.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, direction);
            return nextPoint;
        }

        public void Control(ConsoleKey key)
        {
            if (key == ConsoleKey.RightArrow)
            {
                direction = Direction.RIGHT;
            }
            if (key == ConsoleKey.LeftArrow)
            {
                direction = Direction.LEFT;
            }
            if (key == ConsoleKey.UpArrow)
            {
                direction = Direction.UP;
            }
            if (key == ConsoleKey.DownArrow)
            {
                direction = Direction.DOWN;
            }
        }

        internal bool Eat(Point food)
        {
            Point head = GetNextPoint();
            if (head.IsHit(food))
            {
                //head.Draw();
                food.symb = head.symb;
                line.Add(food);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
