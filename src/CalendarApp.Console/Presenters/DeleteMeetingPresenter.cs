using CalendarApp.Console.Presenters.Interfaces;
using CalendarApp.Console.Views.Interfaces;
using CalendarApp.Domain.Services.Interfaces;

namespace CalendarApp.Console.Presenters;

internal class DeleteMeetingPresenter : IPresenter
{
	private readonly IMeetingsService _meetingService;
	private readonly IView _view;

	public DeleteMeetingPresenter(IMeetingsService meetingsService, IView view)
	{
		_meetingService = meetingsService;
		_view = view;
	}

	public IPresenter Action()
	{
		var meetingName = _view.ReadRow();
		var meetings = _meetingService.GetAllMeetings();

		if (meetings.Where(x => x.Name == meetingName).Count() == 0)
		{
			_view.Print($"There is no meeting with name '{meetingName}'");
		}
		else
		{
			_meetingService.DeleteMeeting(meetingName);
			_view.Print($"All meetings with mane '{meetingName}' was deleted");
		}

		_view.Print("Press any key to continue...");
		_view.ReadKey();

		return new MainMenuPresenter();
	}

	public void Show()
	{
		_view.Clear();
		_view.Print("Enter meeting name:");
	}
}