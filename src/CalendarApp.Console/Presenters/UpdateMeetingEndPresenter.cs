using CalendarApp.Console.Presenters.Interfaces;
using CalendarApp.Domain;
using CalendarApp.Domain.Builders;
using CalendarApp.Domain.Exceptions;
using CalendarApp.Domain.Services.Interfaces;

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
                var endTime = ReadLine();
                _meetingBuilder.SetEnd(endTime);
                return new UpdateMeetingPresenter(_meetingBuilder, Factory.MeetingsService);
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