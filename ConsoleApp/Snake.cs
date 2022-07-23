using System.Collections.Generic;
using System;
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
    public IEnumerable<Point> Body => _body;
    public Direction Direction { get; set; } = Direction.Right;

    public int Size => _body.Count;
    public Point Head => _body[_body.Count - 1];

    public int _axisXDiff = 1;
    public int _axisYDiff = 0;

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
        for (var i = 0; i < _body.Count - 1; ++i)
        {
            var prevPart = _body[i];
            var nextPart = _body[i + 1];

            prevPart.X = nextPart.X;
            prevPart.Y = nextPart.Y;
        }

        Head.X = Head.X + _axisXDiff;
        Head.Y = Head.Y + _axisYDiff;


    }

    public bool TryGrow(int foodX, int foodY)
    {
        var head = Head;
        if (head.X == foodX && head.Y == foodY)
        {
            int newPointX;
            int newPointY;
            if (Direction == Direction.Right)
            {
                newPointX = head.X + 1;
                newPointY = head.Y;
            }
            else if (Direction == Direction.Left)
            {
                newPointX = head.X - 1;
                newPointY = head.Y;
            }
            else if (Direction == Direction.Up)
            {
                newPointX = head.X;
                newPointY = head.Y - 1;
            }
            else if (Direction == Direction.Down)
            {
                newPointX = head.X;
                newPointY = head.Y + 1;
            }
            else
            {
                throw new Exception("Unknown direction");
            }


            _body.Add(new Point { X = newPointX, Y = newPointY });
            return true;


        }
        return false;


    }

    public void TheButtonPressed(ConsoleKeyInfo key)
    {
        switch (key.Key)
        {
            case ConsoleKey.LeftArrow:
                if (Direction != Direction.Right)
                {
                    _axisXDiff = -1;
                    _axisYDiff = 0;
                    Direction = Direction.Left;
                }
                break;
            case ConsoleKey.UpArrow:
                if (Direction != Direction.Down)
                {
                    _axisXDiff = 0;
                    _axisYDiff = -1;
                    Direction = Direction.Up;
                }
                break;
            case ConsoleKey.RightArrow:
                if (Direction != Direction.Left)
                {
                    _axisXDiff = 1;
                    _axisYDiff = 0;
                    Direction = Direction.Right;
                }
                break;
            case ConsoleKey.DownArrow:
                if (Direction != Direction.Up)
                {
                    _axisXDiff = 0;
                    _axisYDiff = 1;
                    Direction = Direction.Down;
                }
                break;


        }
    }
}