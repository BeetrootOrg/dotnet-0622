using CalendarApp.Console.Presenters.Interfaces;
using CalendarApp.Domain.Builders;
using CalendarApp.Domain.Exceptions;


namespace CalendarApp.Console.Presenters;

internal class UpdateMeetingEndPreseneter : IPresenter
{
	private readonly MeetingBuilder _meetingBuilder;

	public UpdateMeetingEndPreseneter(MeetingBuilder meetingBuilder)
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
				return new UpdateMeetingRoomPresenter(_meetingBuilder);

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
		WriteLine("Enter new meeting end date:");
	}
}