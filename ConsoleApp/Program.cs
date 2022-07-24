using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace SnakeGame;
class Program
{
    static void Main(string[] args)
    {
        var app = new SnakeGameApp();
        app.Run();
        if (System.Diagnostics.Debugger.IsAttached)
        {
            Console.WriteLine("\nPress <Enter> to continue...");
            Console.ReadLine();
        }
    }
}
