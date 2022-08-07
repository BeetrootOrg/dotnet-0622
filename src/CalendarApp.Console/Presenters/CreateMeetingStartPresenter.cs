using CalendarApp.Console.Presenters.Interfaces;
using CalendarApp.Domain.Builders;
using CalendarApp.Domain.Exceptions;

namespace CalendarApp.Console.Presenters;

internal class CreateMeetingStartPresenter : IPresenter
{
	private readonly MeetingBuilder _meetingBuilder;

	public CreateMeetingStartPresenter(MeetingBuilder meetingBuilder)
	{
		_meetingBuilder = meetingBuilder;
	}

	public IPresenter Action()
	{
		while (true)
		{
			try
			{
				var name = ReadLine();
				_meetingBuilder.SetStart(name);
				return new CreateMeetingEndPresenter(_meetingBuilder);
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