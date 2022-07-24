using System;

using ConsoleApp.Interfaces;

namespace ConsoleApp;

class GrowEffect : ISnakeEffect, IEffect
{
    public static readonly GrowEffect Instance = new();

    private GrowEffect()
    {
    }

    public void AffectSnake(Snake snake)
    {
        snake.Grow();
    }
}

class DieEffect : ISnakeEffect, IEffect
{
    public static readonly DieEffect Instance = new();

    private DieEffect()
    {
    }

    public void AffectSnake(Snake snake)
    {
        throw new ArgumentOutOfRangeException("You died!");
    }
}
