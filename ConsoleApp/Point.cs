namespace ConsoleApp;

class Point
{
    public int X {get;set;}
    public int Y {get;set;}

    public Point (int x, int y)
    {
        X = x;
        Y = y;
    }

    public bool Equals(Point point) 
    {
        if (X == point.X && Y == point.Y) return true;
        return false;
    }
}