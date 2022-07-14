using System.Collections.Generic;
using System;
namespace ConsoleApp;

class Snake
{
    private List<Point> _body;
    public IEnumerable<Point> Body => _body;


    private int _deltaX = 1;
    private int _deltaY;

    public Snake(int size = 5)
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

        int j = 0;
        foreach (var point in _body)
        {   
            if (++j != snakeLenght && point.X == head.X && point.Y == head.Y)
            {
                throw new ("Game over");
            }
        }        
    }

    public void OnArrowPressed(ConsoleKeyInfo key)
    {   
       switch (key.Key)
        {
          case ConsoleKey.UpArrow:
            _deltaX = 0;
            _deltaY = -1;
            break;
          case ConsoleKey.DownArrow:
            _deltaX = 0;
            _deltaY = 1;
            break;
          case ConsoleKey.RightArrow:
            _deltaX = 1;
            _deltaY = 0;
              break;
          case ConsoleKey.LeftArrow:
            _deltaX = -1;
            _deltaY = 0;
              break;     
        }
    }
}