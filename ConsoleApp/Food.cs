namespace ConsoleApp;

record struct Food(Point Position)
{
    public static Food Random(int size)
    {
        var radom = new Random((int)DateTime.Now.Ticks);
        return new Food(new Point
        {
            X = radom.Next(1, size - 1),
            Y = radom.Next(1, size - 1)
        });
    }
}