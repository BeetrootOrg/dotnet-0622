namespace ConsoleApp;

enum Direction
{
    Pause,
    Up,
    Right,
    Down,
    Left,
    Dead
}

class Snake
{
    private Point _action;

    private List<Point> _body;

    private Direction _direction;

    private int _indexBorder;

    public IEnumerable<Point> Body => _body;

    public bool HitMyself()
    {
        for (int a = 0; a < _body.Count - 4; ++a)
        {
            if (_body[a] == _body[_body.Count - 1])
            {
                return true;
            }
        }
        return false;
    }

    public bool Contains(Point point)
    {
        foreach (var item in _body)
        {
            if (item == point)
            {
                return true;
            }
        }
        return false;
    }

    private bool Eat(Point food)
    {
        if (food == Teleport(_body[_body.Count - 1] + _action))
        {
            _body.Add(new Point
            {
                X = food.X,
                Y = food.Y
            });
            return true;
        }
        return false;
    }

    public bool Move(Point food, ConsoleKey key)
    {
        var eat = false;
        if (HitMyself())
        {
            _direction = Direction.Dead;
        }
        else
        {
            ReadDirection(key);
            SetDirection();
            eat = Eat(food);
            if (!eat && (_action.X != 0 || _action.Y != 0))
            {
                for (var a = 0; a < _body.Count - 1; ++a)
                {
                    _body[a] = _body[a + 1];
                }
                _body[_body.Count - 1] = Teleport(_body[_body.Count - 1] + _action);
            }
        }
        return eat;
    }

    private Point Teleport(Point start)
    {
        if (start.X == _indexBorder)
        {
            start.X = 1;
        }
        else if (start.X == 0)
        {
            start.X = _indexBorder - 1;
        }

        else if (start.Y == _indexBorder)
        {
            start.Y = 1;
        }
        else if (start.Y == 0)
        {
            start.Y = _indexBorder - 1;
        }
        return start;
    }

    private void ReadDirection(ConsoleKey key)
    {
        if (_direction != Direction.Dead)
        {
            if (key == ConsoleKey.DownArrow || key == ConsoleKey.S)
            {
                _direction = Direction.Down;
            }
            else if (key == ConsoleKey.LeftArrow || key == ConsoleKey.A)
            {
                _direction = Direction.Left;
            }
            else if (key == ConsoleKey.RightArrow || key == ConsoleKey.D)
            {
                _direction = Direction.Right;
            }
            else if (key == ConsoleKey.UpArrow || key == ConsoleKey.W)
            {
                _direction = Direction.Up;
            }
            else if (key == ConsoleKey.P)
            {
                _direction = Direction.Pause;
            }
        }
    }

    private void SetDirection()
    {
        int index = _body.Count - 1;

        if (_direction == Direction.Down)
        {
            if (_body[index - 1].Y != _body[index].Y + 1)
            {
                _action.X = 0;
                _action.Y = 1;
            }
        }
        else if (_direction == Direction.Left)
        {
            if (_body[index - 1].X != _body[index].X - 1)
            {
                _action.X = -1;
                _action.Y = 0;
            }
        }
        else if (_direction == Direction.Right)
        {
            if (_body[index - 1].X != _body[index].X + 1)
            {
                _action.X = 1;
                _action.Y = 0;
            }
        }
        else if (_direction == Direction.Up)
        {
            if (_body[index - 1].Y != _body[index].Y - 1)
            {
                _action.X = 0;
                _action.Y = -1;
            }
        }
        else if (_direction == Direction.Pause)
        {
            _action.X = 0;
            _action.Y = -0;
        }
    }

    public Snake(int bodySize = 3, int indexBorder = 7)
    {
        _action = new Point()
        {
            X = 0,
            Y = 0
        };

        _body = new List<Point>();
        for (int a = 0; a < bodySize; ++a)
        {
            _body.Add(new Point
            {
                X = a + 1,
                Y = 1
            });
        }

        _direction = Direction.Pause;

        _indexBorder = indexBorder;
    }

}