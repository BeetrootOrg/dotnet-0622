using CalendarApp.Console.Presenters.Interfaces;
using CalendarApp.Contracts;
using CalendarApp.Domain.Builders;
using CalendarApp.Domain.Exceptions;
using CalendarApp.Domain.Services;

namespace CalendarApp.Console.Presenters;

internal class UpdateMeetingEndPresenter : IPresenter
{
	private readonly MeetingBuilder _meetingBuilder;

	public UpdateMeetingEndPresenter(MeetingBuilder meetingBuilder)
	{
		_meetingBuilder = meetingBuilder;
	}

    public IPresenter Action()
    {
        while (true)
        {
            try
            {
                var meetingStart = ReadLine();
                _meetingBuilder.SetEnd(meetingStart);
                return new UpdateMeetingPresenter(_meetingBuilder);
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
        WriteLine("Enter new meeting end:");
    }
}