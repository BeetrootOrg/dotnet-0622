namespace Snake;
class Snake : Figure
{
   private Direction _direction;
    public Snake(Point tail, int lenght, Direction direction)
    {
        _direction = direction;
        PointList = new List<Point>();
        for (int i = 0; i < lenght; i++)
        {
            Point p = new Point(tail);
            p.Move(i, direction);
            PointList.Add(p);
        }
    }

    public void Move()
    {
        Point tail = PointList.First();
        PointList.Remove(tail);
        Point head = GetNextPoint();
        PointList.Add(head);

        tail.Clear();
        head.Draw();
    }

    public Point GetNextPoint()
    {
        Point head = PointList.Last();
        Point nextPoint = new Point(head);
        nextPoint.Move(1, _direction);
        return nextPoint;
    }
    public bool IsHitTail()
    {
        var head = PointList.Last();
        for (int i = 0; i < PointList.Count - 2; i++)
        {
            if (head.IsHit(PointList[i]))
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
            PointList.Add(food);
            return true;
        }
        else return false;
    }
}
