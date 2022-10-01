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

    public Point Action => _action;

    public IEnumerable<Point> Body => _body;

    public int BodySize => _bodySize;

    public Direction Direction => _direction;

    public int IndexBorder
    {
        get
        {
            return _indexBorder;
        }
        set
        {
            _indexBorder = value;
        }
    }

    public Snake(int bodySize = 3, int indexBorder = 7)
    {
        _action = new Point()
        {
            X = 1,
            Y = 0
        };
        _bodySize = bodySize;

        _body = new List<Point>();
        for (int a = 0; a < _bodySize; ++a)
        {
            _body.Add(new Point
            {
                X = a + 1,
                Y = 1
            });
        }

        _direction = Direction.Left;

        _indexBorder = indexBorder;

    }

    public void Move()
    {
        SetDirection();
        if (_action.X != 0 || _action.Y != 0)
        {
            for (var a = 0; a < _body.Count - 1; ++a)
            {
                _body[a].X = _body[a + 1].X;
                _body[a].Y = _body[a + 1].Y;
            }
            _body[_body.Count - 1].X += _action.X;
            _body[_body.Count - 1].Y += _action.Y;
        }
        Teleport();
    }

    public void Teleport()
    {
        if (_body[_body.Count - 1].X >= _indexBorder)
        {
            _body[_body.Count - 1].X = 1;
        }
        if (_body[_body.Count - 1].X < 1)
        {
            _body[_body.Count - 1].X = _indexBorder;
        }

        if (_body[_body.Count - 1].Y >= _indexBorder)
        {
            _body[_body.Count - 1].Y = 1;
        }
        if (_body[_body.Count - 1].Y < 1)
        {
            _body[_body.Count - 1].Y = _indexBorder;
        }
    }

    public void ReadDirection(object sender, ConsoleKey key)
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
        else
        {
            _direction = Direction.OnThePot;
        }
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
}