using CalendarApp.Console.Presenters.Interfaces;
using CalendarApp.Domain.Builders;
using CalendarApp.Domain.Exceptions;
using CalendarApp.Domain.Services.Interfaces;

namespace CalendarApp.Console.Presenters;

internal class CreateMeetingPresenter : IPresenter
{
	private readonly MeetingBuilder _meetingBuilder;
	private readonly IMeetingsService _meetingService;

	public CreateMeetingPresenter(MeetingBuilder meetingBuilder, IMeetingsService meetingsService)
	{
		_meetingBuilder = meetingBuilder;
		_meetingService = meetingsService;
	}

	public IPresenter Action()
	{
		try
		{
			var meeting = _meetingBuilder.Build();
			_meetingService.AddMeeting(meeting);

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