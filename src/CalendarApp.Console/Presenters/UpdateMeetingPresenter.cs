using CalendarApp.Console.Presenters.Interfaces;
using CalendarApp.Domain.Builders;
using CalendarApp.Domain.Exceptions;
using CalendarApp.Domain.Services.Interfaces;

namespace CalendarApp.Console.Presenters;

internal class UpdateMeetingPresenter : IPresenter
{
	private readonly MeetingUpdater _meetingUpdater;
	private readonly IMeetingsService _meetingService;

	public UpdateMeetingPresenter(MeetingUpdater meetingUpdater, IMeetingsService meetingsService)
	{
		_meetingUpdater = meetingUpdater;
		_meetingService = meetingsService;
	}

	public IPresenter Action()
	{
		try
		{
			var meeting = _meetingUpdater.Build();
			_meetingService.UpdateMeeting(meeting);

			WriteLine("Meeting successfully created!");
		}
		catch (CalendarAppDomainException exc)
		{
			WriteLine(exc.Message);
		}

		WriteLine("Press any key to continue...");
		ReadKey();

		return new MainMenuPresenter();
	}

	public void Show()
	{
	}
}