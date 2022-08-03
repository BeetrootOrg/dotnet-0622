using CalendarApp.Console.Presenters.Interfaces;
using CalendarApp.Domain.Builders;
using CalendarApp.Domain.Exceptions;
using CalendarApp.Domain.Services.Interfaces;

namespace CalendarApp.Console.Presenters;

internal class UpdateMeetingPresenter : IPresenter
{
    private readonly MeetingBuilder _meetingBuilder;
	private readonly IMeetingsService _meetingService;

	public UpdateMeetingPresenter(IMeetingsService meetingsService, MeetingBuilder meetingBuilder)
	{
		_meetingService = meetingsService;
        _meetingBuilder = meetingBuilder;
	}

	public IPresenter Action()
	{
		try
		{
			var meeting = _meetingBuilder.Build();
			_meetingService.AddMeeting(meeting);

			WriteLine("Meeting successfully updated!");
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