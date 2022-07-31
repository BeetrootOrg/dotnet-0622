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
}