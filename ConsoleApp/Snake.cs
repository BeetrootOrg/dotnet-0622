using System.Collections.Generic;
using System;
using static System.Console;
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
    private Direction CurrentDirection { get; set; }
    private Direction NewDirection { get; set; }
    private int _pointX = 1;
    private int _pointY;

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
    public void EatFood()
    {
        _body.Insert(0, new Point { X = 0, Y = 0 });
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
        var head = _body[_body.Count - 1];
        head.X = head.X + _pointX;
        head.Y = head.Y + _pointY;
        CurrentDirection = NewDirection;
    }
    public void ReadMovement(ConsoleKey key)
    {
        CurrentDirection = key switch
        {
            ConsoleKey.UpArrow when CurrentDirection != Direction.Down => Direction.Up,
            ConsoleKey.DownArrow when CurrentDirection != Direction.Up => Direction.Down,
            ConsoleKey.LeftArrow when CurrentDirection != Direction.Right => Direction.Left,
            ConsoleKey.RightArrow when CurrentDirection != Direction.Left => Direction.Right,
            _ => CurrentDirection
        };
        if (CurrentDirection == Direction.Down)
        {
            _pointX = 0;
            _pointY = 1;
            NewDirection = Direction.Down;
        }
        if (CurrentDirection == Direction.Up)
        {
            _pointX = 0;
            _pointY = -1;
            NewDirection = Direction.Up;
        }
        if (CurrentDirection == Direction.Left)
        {
            _pointX = -1;
            _pointY = 0;
            NewDirection = Direction.Left;
        }
        if (CurrentDirection == Direction.Right)
        {
            _pointX = 1;
            _pointY = 0;
            NewDirection = Direction.Right;
        }
    }
}