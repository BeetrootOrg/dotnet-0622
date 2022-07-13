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
    public IEnumerable<Point> Body => _body;
    public Direction Direction { get; set; }

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

        var head = _body[_body.Count - 1];
        head.X = head.X + 1;
    }

    void OnArrowPressed()
    {
        
    }
}