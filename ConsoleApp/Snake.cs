using System;
using System.Collections.Generic;
using System.Linq;

namespace Snake
{
    class Snake : Figure
    {
        Direction direction;
        public Snake(Point tail, int lenght, Direction _direction)
        {
            direction = _direction;
            pList = new List<Point>();
            for (int i = 0; i < lenght; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                pList.Add(p);
            }
        }

        internal void Move()
        {
            Point tail = pList.First();
            pList.Remove(tail);
            Point head = GetNextPoint();
            pList.Add(head);

            tail.Clear();
            head.Draw();
        }

        public Point GetNextPoint()
        {
            Point head = pList.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, direction);
            return nextPoint;
        }
        internal bool IsHitTail()
        {
            var head = pList.Last();
            for (int i = 0; i < pList.Count - 2; i++)
            {
                if (head.IsHit(pList[i]))
                    return true;
            }
            return false;
        }

        ConsoleKey oldKey = ConsoleKey.LeftArrow;
        public void HandleKey(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
            {
                if (oldKey != ConsoleKey.RightArrow)
                {
                    direction = Direction.LEFT;
                    oldKey = key;
                }
            }
            else if (key == ConsoleKey.RightArrow)
            {
                if (oldKey != ConsoleKey.LeftArrow)
                {
                    direction = Direction.RIGHT;
                    oldKey = key;
                }
            }
            else if (key == ConsoleKey.DownArrow)
            {
                if (oldKey != ConsoleKey.UpArrow)
                {
                    direction = Direction.DOWN;
                    oldKey = key;
                }
            }
            else if (key == ConsoleKey.UpArrow)
            {
                if (oldKey != ConsoleKey.DownArrow)
                {
                    direction = Direction.UP;
                    oldKey = key;
                }
            }
        }

        internal bool Eat(Point food)
        {
            Point head = GetNextPoint();
            if (head.IsHit(food))
            {
                food.sym = head.sym;
                pList.Add(food);
                return true;
            }
            else return false;
        }
    }
}