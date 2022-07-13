namespace ConsoleApp;

class Food
{
    private Point Point {get;set;}

    public bool Equals(Point point)
    {
        if (Point.X == point.X && Point.Y == point.Y) return true;
        return false;
    }
    
    public Food (int size)
    {
        var random = new Random((int)DateTime.Now.Ticks);
        Point = new Point(random.Next(1, size - 1), random.Next(1, size - 1));
    }

    public Food (Point point)
    {
        Point = new Point(point.X, point.Y);
    }

    public void Render()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.SetCursorPosition(Point.X, Point.Y);
        Console.Write('@');
    }
}