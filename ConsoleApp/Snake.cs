namespace ConsoleApp;

enum Direction
{
    OnThePot,
    Up,
    Right,
    Down,
    Left
}

class Snake
{
    private Point _action;

    private List<Point> _body;

    private int _bodySize;

    private int _fieldSize;

    public Point Action => _action;

    public IEnumerable<Point> Body => _body;

    public int BodySize => _bodySize;

    public int FieldSize => _fieldSize;

    public Snake(int bodySize = 3)
    {
        _bodySize = bodySize;

        _body = new List<Point>();
        for (int a = 0; a < _bodySize; ++a)
        {
            _body.Add(new Point
            {
                X = a + 1,
                Y = 1
            });
        }
    }

    public void Move(Point action, int fieldSize)
    {
        --fieldSize;
        if (action.X != 0 || action.Y != 0)
        {
            for (var a = 0; a < _body.Count - 1; ++a)
            {
                _body[a].X = _body[a + 1].X;
                _body[a].Y = _body[a + 1].Y;
            }
            _body[_body.Count - 1].X += action.X;
            _body[_body.Count - 1].Y += action.Y;
        }

        if (_body[_body.Count - 1].X >= fieldSize)
        {
            _body[_body.Count - 1].X = 1;
        }
        if (_body[_body.Count - 1].X < 1)
        {
            _body[_body.Count - 1].X = fieldSize;
        }

        if (_body[_body.Count - 1].Y >= fieldSize)
        {
            _body[_body.Count - 1].Y = 1;
        }
        if (_body[_body.Count - 1].Y < 1)
        {
            _body[_body.Count - 1].Y = fieldSize;
        }
    }
}