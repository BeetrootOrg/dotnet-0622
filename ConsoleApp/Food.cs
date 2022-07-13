namespace ConsoleApp;

class Food
{
    private Point _point;

    public bool Equals(Point point) => (_point.X == point.X && _point.Y == point.Y) ? true : false;
    
    public Food (Point point)
    {
        _point = new Point(point.X, point.Y);
    }

    public void Render()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.SetCursorPosition(_point.X, _point.Y);
        Console.Write('@');
    }
}