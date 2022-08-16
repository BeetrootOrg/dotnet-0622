using CalendarApp.Console.Presenters.interfaces;
using static System.Console;

namespace CalendarApp.Console.Presenters;

class ShowAllPresenter : IPresenter
{
    public IPresenter Action()
    {
        ReadKey();
        return new MainMenuPresenter();
    }

    public void Show()
    {
        Clear();

        WriteLine("PLACEHOLDER");
        WriteLine("Press any key to continue...");

    }
}
