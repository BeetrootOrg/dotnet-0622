using System;
using System.Threading;

namespace ConsoleApp;

class Game
{
    private const double Accelarator = 0.9;

    private Direction _direction = Direction.Right;
    private Direction _lastMove = Direction.Right;

    public Renderer Renderer { get; init; }
    public Direction Direction
    {
        get => _direction;
        set
        {
            if (!(_lastMove == Direction.Up && value == Direction.Down ||
                _lastMove == Direction.Down && value == Direction.Up ||
                _lastMove == Direction.Left && value == Direction.Right ||
                _lastMove == Direction.Right && value == Direction.Left))
            {
                _direction = value;
            }
            else
            {
                _direction = _lastMove;
            }
        }
    }

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
        _lastMove = Direction;
        if (Renderer.GameField.MoveSnake(Direction) != null)
        {
            _speed *= Accelarator;
            _timer.Change(_speed, _speed);
        }

        Renderer.Show();
    }
}