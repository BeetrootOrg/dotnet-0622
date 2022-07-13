using System;
using System.Threading;

namespace ConsoleApp;

class Renderer
{
    public Field Field {get;init;}
    private Timer _timer;

    public Renderer()
    {
        _timer = new Timer(Update, null, Timeout.InfiniteTimeSpan, TimeSpan.Zero);
    }

    public void StartGame()
    {
        _timer.Change(TimeSpan.Zero, TimeSpan.FromMilliseconds(200));
    }

    public void Show()
    {
        Field.Render();      
        Console.CursorVisible = false;
    }
    private void Update(object state)
    {
        Field.Update();
        Console.Clear();
        Show();
    }
}