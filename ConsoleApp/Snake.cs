using System.Collections.Generic;
using System;
namespace ConsoleApp;

enum Directions
{
    Right,
    Left,
    Up,
    Down
}

class Snake
{
    private List<Point> _body;
    public IEnumerable<Point> Body => _body;

    public bool IsFoodEated {get; set;} = false;

    private Directions _prevDirection {get; set;} = Directions.Right;
    private Directions _newDirection {get; set;}
    private int _deltaX = 1;
    private int _deltaY;

    public Snake(int size = 3)
    {
        _body = new List<Point>(size);

        for (var i = 0; i < size; ++i)
        {
            _body.Add(new Point
            {
                X = i + 1,
                Y = 5
            });
        }
    }

    public void Move()
    {        
        if(IsFoodEated) _body.Insert(0, new Point { X = 0, Y = 0});
        IsFoodEated = false;


        var snakeLenght = _body.Count;

        for (var i = 0; i < snakeLenght - 1; ++i)
        {
            var prevPart = _body[i];
            var nextPart = _body[i + 1];

            prevPart.X = nextPart.X;
            prevPart.Y = nextPart.Y;
        }


        var head = _body[snakeLenght - 1];
        head.X = head.X + _deltaX;
        head.Y = head.Y + _deltaY;
        _prevDirection = _newDirection;      
    }

    public void OnArrowPressed(ConsoleKeyInfo key)
    {   
       switch (key.Key)
        {
          case ConsoleKey.UpArrow:
            if(_prevDirection != Directions.Down)
            {
                _deltaX = 0;
                _deltaY = -1;
                _newDirection = Directions.Up;
            } 
            break;
          case ConsoleKey.DownArrow:
            if(_prevDirection != Directions.Up)
            {           
                _deltaX = 0;
                _deltaY = 1;
                _newDirection = Directions.Down;
            }
            break;
          case ConsoleKey.RightArrow:
            if(_prevDirection != Directions.Left)
            {
                _deltaX = 1;
                _deltaY = 0;
                _newDirection = Directions.Right;
            }
            break;
          case ConsoleKey.LeftArrow:
            if(_prevDirection != Directions.Right)
            {
                _deltaX = -1;
                _deltaY = 0;
                _newDirection = Directions.Left;
            }
             break;     
        }
    }
}