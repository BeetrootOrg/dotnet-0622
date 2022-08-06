namespace Snake.Console.Presenter.GameProcess;

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
        ForegroundColor = ConsoleColor.Red;
        SetCursorPosition(_point.X, _point.Y);
        Write('@');
    }
}