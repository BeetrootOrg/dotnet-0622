using CalendarApp.Console.Presenters.Interfaces;
using CalendarApp.Domain.Exceptions;
using CalendarApp.Domain.Builders;
using CalendarApp.Domain.Services.Interfaces;

namespace CalendarApp.Console.Presenters;

internal class UpdateMeetingByNamePresenter : IPresenter
{
	private readonly IMeetingsService _meetingService;

	public UpdateMeetingByNamePresenter(IMeetingsService meetingService)
	{
		_meetingService = meetingService;
	}

	public IPresenter Action()
	{
		while (true)
		{
			try
			{
				var name = ReadLine();

				var meeting = _meetingService.GetMeetingByName(name);
				
				return  new UpdateMeetingStartPresenter(new MeetingUpdater(meeting));

				WriteLine("Meeting successfully found!");
				
			}
			catch (CalendarAppDomainException exc)
			{
				WriteLine(exc.Message);
			}
			
			WriteLine("Press any key to continue...");
			ReadKey();
			return new MainMenuPresenter();
		}
	}

	public void Show()
	{
		Clear();
		WriteLine("Enter meeting name:");
	}
}