using System;

namespace ConsoleApp;

enum Dimension
{
    X,
    Y
}

struct Vector : IEquatable<Vector>
{
    public double X { get; init; }
    public double Y { get; init; }

    public double this[Dimension dim]
    {
        get => dim switch
        {
            Dimension.X => X,
            Dimension.Y => Y,
            _ => throw new ArgumentOutOfRangeException(nameof(dim))
        };
    }

    public Vector(double x, double y)
    {
        X = x;
        Y = y;
    }

    public override bool Equals(object obj)
    {
        if (obj is Vector vector)
        {
            return Equals(vector);
        }

        return false;
    }

    public override int GetHashCode()
    {
        var hashCode = new HashCode();
        hashCode.Add(X);
        hashCode.Add(Y);
        return hashCode.ToHashCode();
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

    public static Vector operator +(Vector v1, Vector v2)
    {
        return new Vector(v1.X + v2.X, v1.Y + v2.Y);
    }

    public static Vector operator -(Vector v1, Vector v2)
    {
        return new Vector(v1.X - v2.X, v1.Y - v2.Y);
    }

    public static bool operator ==(Vector v1, Vector v2)
    {
        return v1.Equals(v2);
    }

    public static bool operator !=(Vector v1, Vector v2)
    {
        return !v1.Equals(v2);
    }

    public static implicit operator double(Vector vector)
    {
        return Math.Sqrt(vector.X * vector.X + vector.Y * vector.Y);
    }

    public static explicit operator int(Vector vector)
    {
        return (int)Math.Round(Math.Sqrt(vector.X * vector.X + vector.Y * vector.Y));
    }
}