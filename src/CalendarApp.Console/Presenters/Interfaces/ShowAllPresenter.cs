using CalendarApp.Console.Presenters.Interfaces;
using static System.Console;

namespace CalendarApp.Console.Presenters;

internal class ShowAllPresenter : IPresenter
{
    public IPresenter Action()
    {
       System.Console.ReadKey();
        return new MainMenuPresenter();

    }

    public void Show()
    {
        System.Console.WriteLine("PlaceHolder");
        System.Console.WriteLine("Press any key .... ");
    }
}