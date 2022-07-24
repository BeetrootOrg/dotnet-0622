using System;

using ConsoleApp.Interfaces;

namespace ConsoleApp;

class GrowEffect : ISnakeEffect, IEffect
{
    public static readonly GrowEffect Instance = new();

    private GrowEffect()
    {
    }


    public void Affect(IEater eater)
    {
        if (eater is Snake snake)
        {
            Affect(snake);
        }
    }

    public void Affect(Snake snake)
    {
        snake.Grow();
    }
}

class DieEffect : IEffect
{
    public static readonly DieEffect Instance = new();

    private DieEffect()
    {
    }

    public void Affect(IEater eater)
    {
        throw new ArgumentOutOfRangeException("You died!");
    }
}
