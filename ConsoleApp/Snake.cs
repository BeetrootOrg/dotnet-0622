namespace ConsoleApp;

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
    private Controller _controller = new Controller();

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

    public bool IsEating(Food food)
    {
        if(food.Equals(_body[_body.Count-1])) return true;
        return false;
    }

    public bool IsHittingWall(Wall walls)
    {
        if (walls.Contains(_body[_body.Count - 1])) return true;
        return false;
    }
    
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
        Console.ForegroundColor = ConsoleColor.Green;
        for(int i = 0; i<_body.Count-1; i++)
        {
            Console.SetCursorPosition(_body[i].X, _body[i].Y);
            Console.Write('O');
        }
        Console.SetCursorPosition(_body[_body.Count-1].X, _body[_body.Count-1].Y);
        if (_direction == Direction.Right) Console.Write('>');
        if (_direction == Direction.Left) Console.Write('<');
        if (_direction == Direction.Up) Console.Write('^');
        if (_direction == Direction.Down) Console.Write('v');
    }
    
    public void Grow()
    {
        _body.Add(new Point(_body[_body.Count-1].X, _body[_body.Count-1].Y));
    }

    public void SetDirection()
    {        
        if (_controller.Key.Key == ConsoleKey.RightArrow && _direction != Direction.Left)  _direction = Direction.Right;
        if (_controller.Key.Key == ConsoleKey.LeftArrow && _direction != Direction.Right) _direction = Direction.Left;
        if (_controller.Key.Key == ConsoleKey.UpArrow && _direction != Direction.Down) _direction = Direction.Up;
        if (_controller.Key.Key == ConsoleKey.DownArrow && _direction != Direction.Up) _direction = Direction.Down;
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