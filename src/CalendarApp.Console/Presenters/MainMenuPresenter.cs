using System;
using CalendarApp.Console.Presenters.Interfaces;
using CalendarApp.DataAccess.Repositories;
using CalendarApp.Domain.Services;
using static System.Console;

namespace CalendarApp.Console.Presenters;

internal class MainMenuPresenter : IPresenter
{
	public IPresenter Action()
	{
		var key = ReadKey();

		switch (key.Key)
		{
			case ConsoleKey.D1:
				return new ShowAllPresenter(new MeetingsService(new MeetingsRepository()));
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
		WriteLine("1 - Show all events");
		WriteLine("0 - Exit");
	}
}