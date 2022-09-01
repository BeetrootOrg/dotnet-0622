using System;
using CalendarApp.Console.Views.Interfaces;

namespace CalendarApp.Console.Views;

internal class ConsoleView : IView
{
    public void Clear()
    {
        System.Console.Clear();
    }

    public void Print(string input)
    {
        System.Console.WriteLine(input);
    }

    public ConsoleKey ReadKey()
    {
        var key = System.Console.ReadKey();
        return key.Key;
    }

    public string ReadRow()
    {
        var line = ReadLine();
        return line;
    }
}