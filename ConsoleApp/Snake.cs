using System;
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

    public void Move(int fieldSize)
    {
        switch (Direction)
        {
            case Direction.Up:
                MoveUp();
                break;
            case Direction.Down:
                MoveDown(fieldSize);
                break;
            case Direction.Right:
                MoveRight(fieldSize);
                break;
            case Direction.Left:
                MoveLeft();
                break;
        }
    }
    private void MoveUp()
    {
        CheckIfHeadMeetsBody();
        for (var i = 0; i < _body.Count - 1; ++i)
        {
            var prevPart = _body[i];
            var nextPart = _body[i + 1];

            prevPart.X = nextPart.X;
            prevPart.Y = nextPart.Y;
        }
        var head = _body[_body.Count - 1];
        head.Y = head.Y - 1;

        if (head.Y == 0)
        {
            Environment.Exit(0);
        }
    }
    private void MoveDown(int fieldSize)
    {
        CheckIfHeadMeetsBody();
        for (var i = 0; i < _body.Count - 1; ++i)
        {
            var prevPart = _body[i];
            var nextPart = _body[i + 1];

            prevPart.X = nextPart.X;
            prevPart.Y = nextPart.Y;
        }
        var head = _body[_body.Count - 1];
        head.Y = head.Y + 1;

        if (head.Y == fieldSize)
        {
            Environment.Exit(0);
        }


    }
    private void MoveRight(int fieldSize)
    {
        CheckIfHeadMeetsBody();
        for (var i = 0; i < _body.Count - 1; ++i)
        {
            var prevPart = _body[i];
            var nextPart = _body[i + 1];

            prevPart.X = nextPart.X;
            prevPart.Y = nextPart.Y;
        }
        var head = _body[_body.Count - 1];
        head.X = head.X + 1;

        if (head.X == fieldSize)
        {
            Environment.Exit(0);
        }


    }
    private void MoveLeft()
    {
        CheckIfHeadMeetsBody();
        for (var i = 0; i < _body.Count - 1; ++i)
        {
            var prevPart = _body[i];
            var nextPart = _body[i + 1];

            prevPart.X = nextPart.X;
            prevPart.Y = nextPart.Y;
        }
        var head = _body[_body.Count - 1];
        head.X = head.X - 1;

        if (head.X == 0)
        {
            Environment.Exit(0);
        }
    }
    private void CheckIfHeadMeetsBody()
    {
        for (int i = 0; i < _body.Count - 1; i++)
        {
            var head = _body[_body.Count - 1];
            if (head.X == _body[i].X && head.Y == _body[i].Y)
            {
                Environment.Exit(0);
            }
        }
    }
}