using System;
using CalendarApp.Console.Presenters.interfaces;

using static System.Console;

namespace CalendarApp.Console.Presenters;

class MainMenuPresenter : IPresenter
{
    public IPresenter Action()
    {
        var key = ReadKey();

        switch(key.Key)
        {
            case ConsoleKey.D1:
                return new ShowAllPresenter();
            case ConsoleKey.D0:
                return null;
            default:
                return this; 
        } 
    }

    public void Show()
    {
        Clear();

        WriteLine("CalendarApp");
        WriteLine();
        WriteLine("1- Show all events");
        WriteLine("0- Exit");
    }
}