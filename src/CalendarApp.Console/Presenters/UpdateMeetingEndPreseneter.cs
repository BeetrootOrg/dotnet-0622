using CalendarApp.Console.Presenters.Interfaces;
//using CalendarApp.Console.Views.Interfaces;
using CalendarApp.Domain.Builders;
using CalendarApp.Domain.Exceptions;
using CalendarApp.Domain.Services.Interfaces;
using DomainFactory = CalendarApp.Domain.Factory;

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
                return new UpdateMeetingPresenter(DomainFactory.MeetingsService, _meetingBuilder);
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