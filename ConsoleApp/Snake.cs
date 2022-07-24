namespace Snake;
class Snake : Figure
{
   private Direction _direction;
    public Snake(Point tail, int lenght, Direction direction)
    {
        _direction = direction;
        pList = new List<Point>();
        for (int i = 0; i < lenght; i++)
        {
            Point p = new Point(tail);
            p.Move(i, direction);
            pList.Add(p);
        }
    }

    public void Move()
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
        nextPoint.Move(1, _direction);
        return nextPoint;
    }
    public bool IsHitTail()
    {
        var head = pList.Last();
        for (int i = 0; i < pList.Count - 2; i++)
        {
            if (head.IsHit(pList[i]))
                return true;
        }
        return false;
    }

    ConsoleKey KeyArrow = ConsoleKey.LeftArrow;
    public void HandleKey(ConsoleKey key)
    {
        if (key == ConsoleKey.LeftArrow)
        {
            if (KeyArrow != ConsoleKey.RightArrow)
            {
                _direction = Direction.LEFT;
                KeyArrow = key;
            }
        }
        else if (key == ConsoleKey.RightArrow)
        {
            if (KeyArrow != ConsoleKey.LeftArrow)
            {
                _direction = Direction.RIGHT;
                KeyArrow = key;
            }
        }
        else if (key == ConsoleKey.DownArrow)
        {
            if (KeyArrow != ConsoleKey.UpArrow)
            {
                _direction = Direction.DOWN;
                KeyArrow = key;
            }
        }
        else if (key == ConsoleKey.UpArrow)
        {
            if (KeyArrow != ConsoleKey.DownArrow)
            {
                _direction = Direction.UP;
                KeyArrow = key;
            }
        }
    }

    public bool Eat(Point food)
    {
        Point head = GetNextPoint();
        if (head.IsHit(food))
        {
            food.Sym = head.Sym;
            pList.Add(food);
            return true;
        }
        else return false;
    }
}
