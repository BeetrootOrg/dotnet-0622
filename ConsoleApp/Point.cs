namespace ConsoleApp;

class Point
{
    public int X { get; set; }
    public int Y { get; set; }

    public override bool Equals(object? obj)
    {
        if (obj == null)
        {
            return false;
        }
        if (this.GetHashCode != obj.GetHashCode)
        {
            return false;
        }
        var point = obj as Point;
        if (this.X == point.X && this.Y == point.Y)
        {
            return true;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }

    public override string? ToString()
    {
        return base.ToString();
    }
}