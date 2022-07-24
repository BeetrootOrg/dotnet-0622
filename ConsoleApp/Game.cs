using System;
using System.Threading;

namespace ConsoleApp;

class Game
{
    private const double Accelarator = 0.9;

    public Renderer Renderer { get; init; }
    public Direction Direction { get; set; } = Direction.Right;

    private TimeSpan _speed = TimeSpan.FromMilliseconds(800);

    private Timer _timer;

    public Game()
    {
        _timer = new Timer(Tick, null, Timeout.InfiniteTimeSpan, TimeSpan.Zero);
    }

    public void StartGame()
    {
        _timer.Change(TimeSpan.Zero, _speed);
    }

    private void Tick(object state)
    {
        if (Renderer.GameField.MoveSnake(Direction) != null)
        {
            _speed *= Accelarator;
            _timer.Change(_speed, _speed);
        }

        Renderer.Show();
    }
}