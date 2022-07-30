using CalendarApp.Console.Presenters.Interfaces;
using CalendarApp.Domain.Builders;
using CalendarApp.Domain.Exceptions;

namespace CalendarApp.Console.Presenters;

internal class UpdateMeetingEndPresenter : IPresenter
{
	private readonly MeetingUpdater _meetingUpdater;

	public UpdateMeetingEndPresenter(MeetingUpdater meetingUpdater)
	{
		_meetingUpdater = meetingUpdater;
	}

	public IPresenter Action()
	{
		while (true)
		{
			try
			{
				var endTime = ReadLine();
				_meetingUpdater.SetStart(endTime);
				return new UpdateMeetingEndPresenter(_meetingUpdater);
			}
			catch (CalendarAppDomainException exc)
			{
				WriteLine(exc.Message);
			}
		}
	}

	public void Show()
	{
		Clear();
		WriteLine("Enter meeting start date:");
	}
}