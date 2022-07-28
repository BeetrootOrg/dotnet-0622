using CalendarApp.Console.Presenters.Interfaces;

namespace CalendarApp.Console.Presenters;
using static System.Console;


class MainMenuPresenter : IPresenter
{
    public void Action()
    {
        var key = System.Console.ReadKey();

        switch (key.Key)
        {
            case ConsoleKey.D0:
                Environment.Exit(0);
                break;

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