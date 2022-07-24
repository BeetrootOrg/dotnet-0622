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
    public Direction PrevDirection { get; set; } = Direction.Right;
    public Direction NextDirection { get; set; }
    public int DirectionX = 1;
    public int DirectionY;
    public bool IsFoodEated {get; set;} = false;


    public Snake(int size = 3)
    {
        _body = new List<Point>(size);

        for (var i = 0; i < size; ++i)
        {
            _body.Add(new Point
            {
                X = i + 1,
                Y = 4
            });
        }
    }

    public void Move()
    {
        if(IsFoodEated) _body.Insert(0, new Point { X = 0, Y = 0});
        IsFoodEated = false;

        var snakeLength = _body.Count;
        for (var i = 0; i < snakeLength - 1; ++i)
        {
            var prevPart = _body[i];
            var nextPart = _body[i + 1];

            prevPart.X = nextPart.X;
            prevPart.Y = nextPart.Y;
        }

        var head = _body[_body.Count - 1];
        head.X = head.X + DirectionX;
        head.Y = head.Y + DirectionY;
        PrevDirection = NextDirection;
    }

    public void EatFood()
    {
        _body.Insert(0, new Point { X = 0, Y = 0 });
    }

    public void OnArrowPressed(ConsoleKeyInfo key)
    {   
       switch (key.Key)
        {
          case ConsoleKey.UpArrow:
            if(PrevDirection != Direction.Down)
            {
                DirectionX = 0;
                DirectionY = -1;
                NextDirection = Direction.Up;
            } 
            break;
          case ConsoleKey.DownArrow:
            if(PrevDirection != Direction.Up)
            {           
                DirectionX = 0;
                DirectionY = 1;
                NextDirection = Direction.Down;
            }
            break;
          case ConsoleKey.RightArrow:
            if(PrevDirection != Direction.Left)
            {
                DirectionX = 1;
                DirectionY = 0;
                NextDirection = Direction.Right;
            }
            break;
          case ConsoleKey.LeftArrow:
            if(PrevDirection != Direction.Right)
            {
                DirectionX = -1;
                DirectionY = 0;
                NextDirection = Direction.Left;
            }
             break;     
        }
    }
}