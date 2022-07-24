using ConsoleApp.Interfaces;

namespace ConsoleApp;

class Point : IPositionable, IPositionComparable
{
    public int X { get; init; }
    public int Y { get; init; }

    public Point()
    {
    }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public Point(IPositionable positionable) : this(positionable.X, positionable.Y)
    {
    }

    public Point Up() => new Point(X, Y - 1);
    public Point Down() => new Point(X, Y + 1);
    public Point Left() => new Point(X - 1, Y);
    public Point Right() => new Point(X + 1, Y);

    public bool SamePosition(IPositionable positionable)
    {
        return X == positionable.X &&
            Y == positionable.Y;
    }

    public void Deconstruct(out int x, out int y)
    {
        x = X;
        y = Y;
    }
}