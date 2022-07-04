using System;

namespace ConsoleApp;

enum Dimension
{
    X,
    Y
}

struct Vector : IEquatable<Vector>
{
    /// <summary>
    /// Vector's X position
    /// </summary>
    public double X { get; init; }

    /// <summary>
    /// Vector's Y position
    /// </summary>
    public double Y { get; init; }

    /// <summary>
    /// X or Y depending on input
    /// </summary>
    /// <param name="dim">Required dimension</param>
    /// <returns>X or Y coordinate</returns>
    /// <exception cref="ArgumentOutOfRangeException">dim value is out of range</exception>
    public double this[Dimension dim]
    {
        get => dim switch
        {
            Dimension.X => X,
            Dimension.Y => Y,
            _ => throw new ArgumentOutOfRangeException(nameof(dim))
        };
    }

    public Vector this[Dimension dim1, Dimension dim2]
    {
        get => new Vector(this[dim1], this[dim2]);
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