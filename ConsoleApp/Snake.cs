namespace ConsoleApp;

enum Direction
{
    OnThePot,
    Up,
    Right,
    Down,
    Left
}

class Snake
{
    private Point _action;

    private List<Point> _body;

    private int _bodySize;

    private Direction _direction;

    private int _indexBorder;

    public IEnumerable<Point> Body => _body;

    public bool Eat(Point food)
    {
        if (food.X == _body[_body.Count - 1].X + _action.X &&
            food.Y == _body[_body.Count - 1].Y + _action.Y)
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
        ReadDirection(key);
        eat = Eat(food);
        if (!eat && (_action.X != 0 || _action.Y != 0))
        {
            for (var a = 0; a < _body.Count - 1; ++a)
            {
                _body[a].X = _body[a + 1].X;
                _body[a].Y = _body[a + 1].Y;
            }
            _body[_body.Count - 1].X += _action.X;
            _body[_body.Count - 1].Y += _action.Y;

            Teleport();
        }
        return eat;
    }

    public void Teleport()
    {
        if (_body[_body.Count - 1].X >= _indexBorder)
        {
            _body[_body.Count - 1].X = 1;
        }
        if (_body[_body.Count - 1].X < 1)
        {
            _body[_body.Count - 1].X = _indexBorder - 1;
        }

        if (_body[_body.Count - 1].Y >= _indexBorder)
        {
            _body[_body.Count - 1].Y = 1;
        }
        if (_body[_body.Count - 1].Y < 1)
        {
            _body[_body.Count - 1].Y = _indexBorder - 1;
        }
    }

    public void ReadDirection(ConsoleKey key)
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
            _direction = Direction.OnThePot;
        }
        else
        {

        }
        SetDirection();
    }

    public void SetDirection()
    {
        int index = _body.Count - 1;

        if (_direction == Direction.Down)
        {
            if (_body[index - 1].Y != _body[index].Y + 1 &&
                _body[index - 1].X != _body[index].X)
            {
                _action.X = 0;
                _action.Y = 1;
            }
        }
        else if (_direction == Direction.Left)
        {
            if (_body[index - 1].Y != _body[index].Y &&
                _body[index - 1].X != _body[index].X - 1)
            {
                _action.X = -1;
                _action.Y = 0;
            }
        }
        else if (_direction == Direction.Right)
        {
            if (_body[index - 1].Y != _body[index].Y &&
                _body[index - 1].X != _body[index].X + 1)
            {
                _action.X = 1;
                _action.Y = 0;
            }
        }
        else if (_direction == Direction.Up)
        {
            if (_body[index - 1].Y != _body[index].Y - 1 &&
                _body[index - 1].X != _body[index].X)
            {
                _action.X = 0;
                _action.Y = -1;
            }
        }
        else
        {
            _action.X = 0;
            _action.Y = 0;
        }
    }

    public Snake(int bodySize = 3, int indexBorder = 7)
    {
        _bodySize = bodySize;

        _action = new Point()
        {
            X = 0,
            Y = 0
        };

        _body = new List<Point>();
        for (int a = 0; a < _bodySize; ++a)
        {
            _body.Add(new Point
            {
                X = a + 1,
                Y = 1
            });
        }

        _direction = Direction.OnThePot;

        _indexBorder = indexBorder;
    }

}