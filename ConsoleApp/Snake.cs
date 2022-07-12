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
    public List<Point> _body;
    public Direction _direcrion {get;set;} = Direction.Right;

    public Snake(int size = 3)
    {
        _body = new List<Point>();

        for (var i = 0; i < size; ++i)
        {
            _body.Add(new Point
            {
                X = i + 1,
                Y = 1
            });
        }
        
    }

    public void SetDirection()
    {
        if(Console.KeyAvailable)
        {
            var key = Console.ReadKey();

            if (key.Key == ConsoleKey.RightArrow && _direcrion != Direction.Left)
            {
                _direcrion = Direction.Right;
            }

            if (key.Key == ConsoleKey.LeftArrow && _direcrion != Direction.Right)
            {
                _direcrion = Direction.Left;
            }

            if (key.Key == ConsoleKey.UpArrow && _direcrion != Direction.Down)
            {
                _direcrion = Direction.Up;
            }

            if (key.Key == ConsoleKey.DownArrow && _direcrion != Direction.Up)
            {
                _direcrion = Direction.Down;
            }
        }
    }   

    public void Move()
    {           
        SetDirection();
        
        if (_direcrion == Direction.Right)
        {
            for (int i = 0; i<_body.Count-1; i++)
            {
                var currentPart = _body[i];
                var nextPart = _body[i + 1];

                currentPart.X = nextPart.X;
                currentPart.Y = nextPart.Y;
            }
            _body[_body.Count-1].X++;
        }

        if (_direcrion == Direction.Left)
        {
            for (int i = 0; i<_body.Count-1; i++)
            {
                var currentPart = _body[i];
                var nextPart = _body[i + 1];

                currentPart.X = nextPart.X;
                currentPart.Y = nextPart.Y;
            }
            _body[_body.Count-1].X--;
        }

        if (_direcrion == Direction.Down)
        {
            for (int i = 0; i<_body.Count-1; i++)
            {
                var currentPart = _body[i];
                var nextPart = _body[i + 1];

                currentPart.X = nextPart.X;
                currentPart.Y = nextPart.Y;
            }
            _body[_body.Count-1].Y++;
        }

        if (_direcrion == Direction.Up)
        {
            for (int i = 0; i<_body.Count-1; i++)
            {
                var currentPart = _body[i];
                var nextPart = _body[i + 1];

                currentPart.X = nextPart.X;
                currentPart.Y = nextPart.Y;
            }
            _body[_body.Count-1].Y--;
        }
        
    }
}