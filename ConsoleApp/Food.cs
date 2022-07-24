using System;

using ConsoleApp.Interfaces;

namespace ConsoleApp;

class Food : IConsumable, IPositionable, IPositionComparable
{
    private readonly Point _point;

    public int X => _point.X;

    public int Y => _point.Y;

    public Food(IPositionable positionable) : this(positionable.X, positionable.Y)
    {
    }

    public Food(int x, int y)
    {
        _point = new Point
        {
            X = x,
            Y = y,
        };
    }

    public static Food Random(int size)
    {
        var random = new Random((int)DateTime.Now.Ticks);
        return new Food(random.Next(1, size - 1), random.Next(1, size - 1));
    }

    public IEffect Consume()
    {
        return GrowEffect.Instance;
    }

    public bool SamePosition(IPositionable positionable)
    {
        return _point.SamePosition(positionable);
    }
}