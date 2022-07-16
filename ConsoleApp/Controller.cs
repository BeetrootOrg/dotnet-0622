using System;
using System.Threading;

namespace ConsoleApp;

class Controller
{
     private Timer _timer;

     public ConsoleKeyInfo Key {get; protected set;} = new ConsoleKeyInfo();

     public Controller()
     {
        _timer = new Timer(ReadKey, null, Timeout.InfiniteTimeSpan, TimeSpan.Zero);
        _timer.Change(TimeSpan.Zero, TimeSpan.FromMilliseconds(10));
     }
     public void ReadKey(object state)
     {
        if (Console.KeyAvailable)
        {
            Key = Console.ReadKey();
        }
     }

     public void Dispose()
     {
         _timer.Dispose();
     }
}