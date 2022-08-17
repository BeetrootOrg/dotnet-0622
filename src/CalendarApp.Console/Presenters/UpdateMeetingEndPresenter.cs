using CalendarApp.Console.Presenters.Interfaces;
using CalendarApp.Domain.Builders;
using CalendarApp.Domain.Exceptions;
using DomainFactory = CalendarApp.Domain.Factory;

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
				_meetingUpdater.SetEnd(endTime);
				return new UpdateMeetingPresenter(_meetingUpdater, DomainFactory.MeetingsService);
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
		WriteLine("Enter meeting end date:");
	}
}