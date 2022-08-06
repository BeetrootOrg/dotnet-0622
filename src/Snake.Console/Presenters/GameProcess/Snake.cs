namespace Snake.Console.Presenter.GameProcess;

enum Direction
{
    Up,
    Right,
    Down,
    Left
}
class Snake
{
    private List<Point> _body;
    private Direction _direction = Direction.Right;
    private SnakeController _controller = new SnakeController();

    public Snake(int size = 3)
    {
        _body = new List<Point>();
        for (var i = 0; i < size; ++i)
        {
            _body.Add(new Point(i+1, 1));
        }
    }

    public bool Contains(Point point)
    {
        foreach(var bodyPoint in _body)
            if(bodyPoint.Equals(point)) return true;
        return false;
    }

    public bool IsEating(Food food) => food.Equals(_body[_body.Count-1]) ? true : false;

    public bool IsHittingWall(Wall walls) => walls.Contains(_body[_body.Count - 1]) ? true : false;
    
    public bool IsEatingHimself()
    {
        for (int i = 0; i < _body.Count-1; i++)
        {
            if (_body[i].Equals(_body[_body.Count-1])) return true;
        }
        return false;
    }
    
    public void Render()
    {
        ForegroundColor = ConsoleColor.Green;
        for(int i = 0; i<_body.Count-1; i++)
        {
            SetCursorPosition(_body[i].X, _body[i].Y);
            Write('O');
        }
        SetCursorPosition(_body[_body.Count-1].X, _body[_body.Count-1].Y);
        if (_direction == Direction.Right) Write('>');
        if (_direction == Direction.Left) Write('<');
        if (_direction == Direction.Up) Write('^');
        if (_direction == Direction.Down) Write('v');
    }
    
    public void Grow()
    {
        _body.Add(new Point(_body[_body.Count-1].X, _body[_body.Count-1].Y));
    }

    private void SetDirection()
    {        
        if (_controller.Key.Key == ConsoleKey.RightArrow && _direction != Direction.Left)  _direction = Direction.Right;
        if (_controller.Key.Key == ConsoleKey.LeftArrow && _direction != Direction.Right) _direction = Direction.Left;
        if (_controller.Key.Key == ConsoleKey.UpArrow && _direction != Direction.Down) _direction = Direction.Up;
        if (_controller.Key.Key == ConsoleKey.DownArrow && _direction != Direction.Up) _direction = Direction.Down;
    }

    public void StopListening()
    {
        _controller.Dispose();
    } 

    public void Move()
    {           
        for (int i = 0; i<_body.Count-1; i++)
        {
            var currentPart = _body[i];
            var nextPart = _body[i + 1];

            currentPart.X = nextPart.X;
            currentPart.Y = nextPart.Y;
        }
        
        SetDirection();
        if (_direction == Direction.Right) _body[_body.Count-1].X++;
        if (_direction == Direction.Left)  _body[_body.Count-1].X--;
        if (_direction == Direction.Down) _body[_body.Count-1].Y++;
        if (_direction == Direction.Up) _body[_body.Count-1].Y--;
        
    }
}