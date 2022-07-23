using System;
namespace ConsoleApp;


class Point :IEquatable<Point>
{
    public int X { get; set; }
    public int Y { get; set; }
    public Point() {}
    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public bool Equals(Point other)
    {
        return X == other.X && Y == other.Y;
    }
    public override string ToString()
    {
        return $"X = {X}, Y = {Y}";
    }
}