using CalendarApp.Console.Presenters.Interfaces;
using CalendarApp.Domain.Builders;
using CalendarApp.Domain.Exceptions;
using CalendarApp.Domain.Services.Interfaces;

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
                var startTime = ReadLine();
                _meetingBuilder.SetStart(startTime);
                return new UpdateMeetingEndPresenter(_meetingBuilder);
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
        WriteLine("Enter new meeting start date:");
    }
}
