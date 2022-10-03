using System;

using static System.Console;

namespace ConsoleApp;

internal class Program
{

    const int Size = 15;
    private static void Main(string[] args)
    {
        var renderer = new Renderer(Size);
        renderer.StartGame();
        Thread.Sleep(Timeout.Infinite);
    }

}