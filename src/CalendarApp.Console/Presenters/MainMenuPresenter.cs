using CalendarApp.Console.Presenters.Interfaces;

using static System.Console;

namespace CalendarApp.Console.Presenters;

class MainMenuPresenter : IPresenter
{
	public void Action()
	{
		var key = ReadKey();

		switch (key.Key)
		{
			case ConsoleKey.D0:
				Environment.Exit(0);
				break;
		}
	}

	public void Show()
	{
		Clear();

		WriteLine("CalendarApp");
		WriteLine();
		// WriteLine("1 - Show all events");
		WriteLine("0 - Exit");
	}
}