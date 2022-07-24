namespace ConsoleApp.Interfaces;

interface IEffect
{
    void Affect(IEater eater);
}

interface ISnakeEffect : IEffect
{
    void Affect(Snake snake);
}