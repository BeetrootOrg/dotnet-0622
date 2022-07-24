namespace Snake;
class Point
{
    public int X;
    public int Y;
    public char Sym;
    public Point()
    {
    }
    public Point(int x, int y, char sym)
    {
        X = x;
        Y = y;
        Sym = sym;
    }

    public Point(Point p)
    {
        X = p.X;
        Y = p.Y;
        Sym = p.Sym;
    }

    public void Move(int offset, Direction direction)
    {
        if (direction == Direction.RIGHT)
        {
            X = X + offset;
        }
        else if (direction == Direction.LEFT)
        {
            X = X - offset;
        }
        else if (direction == Direction.UP)
        {
            Y = Y - offset;
        }
        else if (direction == Direction.DOWN)
        {
            Y = Y + offset;
        }
    }

    public void Clear()
    {
        Sym = ' ';
        Draw();
    }

    public void Draw()
    {
        Console.SetCursorPosition(X, Y);
        Console.Write(Sym);
    }

    public override string ToString()
    {
        return $"{X}, {Y}, {Sym}";
    }

    public bool IsHit(Point p)
    {
        return p.X == X && p.Y == Y;
    }
}
