using CalendarApp.Console.Presenters.Interfaces;

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