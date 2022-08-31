using CalendarApp.Console.Presenters.Interfaces;
using CalendarApp.Console.Views.Interfaces;
using CalendarApp.Domain.Services.Interfaces;

namespace CalendarApp.Console.Presenters;

internal class ShowAllPresenter : IPresenter
{
	private readonly IMeetingsService _meetingService;
	private readonly IView _view;

	public ShowAllPresenter(IMeetingsService meetingService, IView view)
	{
		_meetingService = meetingService;
		_view = view;
	}

	public IPresenter Action()
	{
		_view.ReadKey();
		return new MainMenuPresenter();
	}

	public void Show()
	{
		_view.Clear();

		_view.Print(string.Format("{0,-25}{1,-25}{2,-25}{3,-25}", "Name", "Start", "End", "Room"));
		foreach (var meeting in _meetingService.GetAllMeetings())
		{
			_view.Print(string.Format("{0,-25}{1,-25}{2,-25}{3,-25}", meeting.Name,
				meeting.Timeframe.Start.ToString("s"),
				meeting.Timeframe.End.ToString("s"),
				meeting.Room.Name));
		}

		_view.Print("Press any key to continue...");
	}
}