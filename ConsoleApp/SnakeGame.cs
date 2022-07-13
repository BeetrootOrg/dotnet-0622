using System;
using System.Threading;

namespace ConsoleApp;

class SnakeGame
{
    private Field _field;
    private Timer _timer;

    public SnakeGame(Field filed)
    {
        _field = filed;
        _timer = new Timer(Update, null, Timeout.InfiniteTimeSpan, TimeSpan.Zero);
    }

    public void StartGame()
    {
        _timer.Change(TimeSpan.Zero, TimeSpan.FromMilliseconds(200));
    }

    public void Show()
    {
        _field.Render();      
        Console.CursorVisible = false;
    }
    private void Update(object state)
    {
        _field.Update();
        Console.Clear();
        Show();
    }
}