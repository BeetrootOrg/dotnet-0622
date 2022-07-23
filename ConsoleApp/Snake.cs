using System.Collections.Generic;

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
    public List<Point> Body => _body;
    public Direction Direction { get; set; } = Direction.Right;
    public Point SnakeHead {get => _body[_body.Count - 1];}
    public Point SnakeTail {get => _body[0];}

    public Snake(int size = 3)
    {
        _body = new List<Point>(size);

        for (var i = 0; i < size; ++i)
        {
            _body.Add(new Point
            {
                X = i + 1,
                Y = i
            });
        }
    }

    public void Move()
    {
        switch (Direction)
        {
            case Direction.Up:
            MoveUp();
            break;
            case Direction.Right:
            MoveRight();
            break;
            case Direction.Left:
            MoveLeft();
            break;
            case Direction.Down:
            MoveDown();
            break;
        }
        
    }

    private void MoveUp()
    {
        for (var i = 0; i < _body.Count - 1; ++i)
        {
            var prevPart = _body[i];
            var nextPart = _body[i + 1];

            prevPart.X = nextPart.X;
            prevPart.Y = nextPart.Y;
        }

        SnakeHead.Y = SnakeHead.Y - 1;
    }
    private void MoveRight()
    {
        for (var i = 0; i < _body.Count - 1; ++i)
        {
            var prevPart = _body[i];
            var nextPart = _body[i + 1];

            prevPart.X = nextPart.X;
            prevPart.Y = nextPart.Y;
        }

        SnakeHead.X = SnakeHead.X + 1;        
    }
    private void MoveLeft()
    {
        for (var i = 0; i < _body.Count - 1; ++i)
        {
            var prevPart = _body[i];
            var nextPart = _body[i + 1];

            prevPart.X = nextPart.X;
            prevPart.Y = nextPart.Y;
        }

        SnakeHead.X = SnakeHead.X - 1;
    }
    private void MoveDown()
    {
        for (var i = 0; i < _body.Count - 1; ++i)
        {
            var prevPart = _body[i];
            var nextPart = _body[i + 1];

            prevPart.X = nextPart.X;
            prevPart.Y = nextPart.Y;
        }

        SnakeHead.Y = SnakeHead.Y + 1;
    }
}