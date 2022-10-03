namespace ConsoleApp;

class Point
{
    public int X { get; set; }

    public int Y { get; set; }

    public static bool operator ==(Point point1, Point point2)
    {
        return point1.X == point2.X && point1.Y == point2.Y;
    }

    public static bool operator !=(Point point1, Point point2)
    {
        return point1.X != point2.X && point1.Y != point2.Y;
    }

    public static Point operator +(Point point1, Point point2)
    {
        return new Point { X = point1.X + point2.X, Y = point1.Y + point2.Y };
    }

}