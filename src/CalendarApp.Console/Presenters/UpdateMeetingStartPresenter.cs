using CalendarApp.Console.Presenters.Interfaces;
using CalendarApp.Domain.Builders;
using CalendarApp.Domain.Exceptions;

namespace CalendarApp.Console.Presenters;

internal class UpdateMeetingStartPresenter : IPresenter
{
    private readonly MeetingBuilder _meetingBuilder;

	public UpdateMeetingStartPresenter(MeetingBuilder meetingBuilder)
	{
        _meetingBuilder = meetingBuilder;
	}

	public IPresenter Action()
	{
		while (true)
		{
			try
			{
				var startDate = ReadLine();
				_meetingBuilder.SetStart(startDate);
				return new UpdateMeetingEndPreseneter(_meetingBuilder);
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