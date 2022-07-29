using CalendarApp.Console.Presenters.Interfaces;
using System;
namespace CalendarApp.Console.Presenters;
using static System.Console;


class MainMenuPresenter : IPresenter
{
    public IPresenter Action()
    {
        var key = System.Console.ReadKey();

        switch (key.Key)
        {
            case ConsoleKey.D0:
                return null;

            case ConsoleKey.D1:
                return new ShowAllPresenter();
            default:
                return this;
        }
    }

    public void Show()
    {
        System.Console.Clear();
        System.Console.WriteLine("Calendar app");
        System.Console.WriteLine();
        System.Console.WriteLine("1 - Show all events");
        System.Console.WriteLine("0 - Exit");
    }
}