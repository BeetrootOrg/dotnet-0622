using CalendarApp.Console.Presenters.Interfaces;
using CalendarApp.Domain.Builders;
using CalendarApp.Domain.Exceptions;

namespace CalendarApp.Console.Presenters;

internal class CreateMeetingEndPresenter : IPresenter
{
	private readonly MeetingBuilder _meetingBuilder;

	public CreateMeetingEndPresenter(MeetingBuilder meetingBuilder)
	{
		_meetingBuilder = meetingBuilder;
	}

	public IPresenter Action()
	{
		while (true)
		{
			try
			{
				var endDate = ReadLine();
				_meetingBuilder.SetEnd(endDate);
				return new CreateMeetingRoomNamePresenter(_meetingBuilder);
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