using System;

namespace ConsoleApp;

record struct Food(Point Position)
{
    public static Food Random(int size)
    {
        var random = new Random((int)DateTime.Now.Ticks);
        return new Food(new Point
        {
            X = random.Next(1, size - 1),
            Y = random.Next(1, size - 1)
        });
    }
}