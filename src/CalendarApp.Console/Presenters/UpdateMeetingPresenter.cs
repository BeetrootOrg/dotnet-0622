using CalendarApp.Console.Presenters.Interfaces;
using CalendarApp.Contracts;
using CalendarApp.Domain;
using CalendarApp.Domain.Builders;
using CalendarApp.Domain.Exceptions;
using CalendarApp.Domain.Services;

namespace CalendarApp.Console.Presenters;

internal class UpdateMeetingPresenter : IPresenter
{
	private readonly MeetingBuilder _meetingBuilder;

	public UpdateMeetingPresenter(MeetingBuilder meetingBuilder)
	{
		_meetingBuilder = meetingBuilder;
	}

    public IPresenter Action()
    {
        try
		{
			var meeting = _meetingBuilder.Build();
			Factory.MeetingsService.UpdateMeeting(meeting);

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