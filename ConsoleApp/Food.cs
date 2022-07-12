namespace ConsoleApp;

class Food
{
    public Point Point {get;set;}
    
    public Food (int size)
    {
        var random = new Random((int)DateTime.Now.Ticks);
        Point = new Point{
            X = random.Next(1, size - 1),
            Y = random.Next(1, size - 1)
        };
    }

    public Food (Point point)
    {
        Point = new Point{
            X = point.X,
            Y = point.Y
        };
    }
}