using CalendarApp.Console.Presenters.Interfaces;
using CalendarApp.Domain.Builders;
using CalendarApp.Domain.Exceptions;

namespace CalendarApp.Console.Presenters;

internal class CreateMeetingNamePresenter : IPresenter
{
    private readonly MeetingBuilder _meetingBuilder;

    public CreateMeetingNamePresenter(MeetingBuilder meetingBuilder)
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
                _meetingBuilder.SetName(name);
                return new CreateMeetingStartPresenter(_meetingBuilder);
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
        WriteLine("Enter meeting name:");
    }
}