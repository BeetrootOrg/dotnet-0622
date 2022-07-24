using System;

namespace ConsoleApp;

class Food
{
    public Point Position {get; private set;}

    public Food (int size)
    {
        
        Position = Random(size);
    }
    
    public Point Random(int size)
    {   
        var random = new Random((int)DateTime.Now.Ticks);     
        int newX = random.Next(1, size - 1);
        int newY = random.Next(1, size - 1);
        
        return new Point
        {
            X = newX,
            Y = newY
        };
    }
}