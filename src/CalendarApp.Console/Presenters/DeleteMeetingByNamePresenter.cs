using CalendarApp.Console.Presenters.Interfaces;
using CalendarApp.Domain.Exceptions;
using CalendarApp.Domain.Services;
using CalendarApp.Domain.Services.Interfaces;

namespace CalendarApp.Console.Presenters;

internal class DeleteMeetingByNamePresenter : IPresenter
{
	private readonly IMeetingsService _meetingService;

	public DeleteMeetingByNamePresenter(IMeetingsService meetingService)
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

				_meetingService.DeleteMeeting(name);



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