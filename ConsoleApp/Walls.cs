namespace ConsoleApp;

class Wall
{
    private List<Point> _walls;
    public Wall()
    {
        _walls = new List<Point>();
        int size = 15;
        for(int i = 0; i<size; i++)
        {
            _walls.Add(new Point(0, i));
            _walls.Add(new Point(size-1, i));
            _walls.Add(new Point(i, 0));
            _walls.Add(new Point(i, size-1));
        }
    }

    public bool Contains(Point point)
    {
        foreach(var wall in _walls)
            if(wall.Equals(point)) return true;
        return false;
    }
    public void Render()
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        foreach(var wall in _walls)
        {
            Console.SetCursorPosition(wall.X, wall.Y);
            Console.Write('#');
        }
    }
}