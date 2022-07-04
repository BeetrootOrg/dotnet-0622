using System;

namespace ConsoleApp;

struct Vector : IEquatable<Vector>
{
    public double X { get; init; }
    public double Y { get; init; }

    public Vector(double x, double y)
    {
        X = x;
        Y = y;
    }


    public bool Equals(Vector other)
    {
        return X == other.X &&
            Y == other.Y;
    }

    public override string ToString()
    {
        return $"{{X: {X}, Y: {Y}}}";
    }
}