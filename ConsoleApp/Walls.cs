namespace ConsoleApp;

class Wall
{
    private List<Point> Walls {get;set;}
    public Wall()
    {
        Walls = new List<Point>();
        int size = 15;
        for(int i = 0; i<size; i++)
        {
            Walls.Add(new Point(0, i));
            Walls.Add(new Point(size-1, i));
            Walls.Add(new Point(i, 0));
            Walls.Add(new Point(i, size-1));
        }
    }

    public bool Contains(Point point)
    {
        foreach(var wall in Walls)
            if(wall.Equals(point)) return true;
        return false;
    }
    public void Render()
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        foreach(var wall in Walls)
        {
            Console.SetCursorPosition(wall.X, wall.Y);
            Console.Write('#');
        }
    }
}