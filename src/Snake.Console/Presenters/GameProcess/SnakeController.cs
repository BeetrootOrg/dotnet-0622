using System;
using System.Threading;

namespace Snake.Console.Presenter.GameProcess;

class SnakeController
{
     private Timer _timer;

     public ConsoleKeyInfo Key {get; protected set;} = new ConsoleKeyInfo();

     public SnakeController()
     {
        _timer = new Timer(Move, null, Timeout.InfiniteTimeSpan, TimeSpan.Zero);
        _timer.Change(TimeSpan.Zero, TimeSpan.FromMilliseconds(10));
     }
     public void Move(object state)
     {
        if (KeyAvailable)
        {
            Key = ReadKey();
        }
     }

     public void Dispose()
     {
         _timer.Dispose();
     }
}