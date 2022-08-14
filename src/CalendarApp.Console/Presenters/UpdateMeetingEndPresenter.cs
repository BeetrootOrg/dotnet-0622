using CalendarApp.Console.Presenters.Interfaces;
using CalendarApp.Domain.Services.Interfaces;
using CalendarApp.Domain.Exceptions;
using CalendarApp.Domain.Builders;
using System.Linq;
using DomainFactory = CalendarApp.Domain.Factory;

namespace CalendarApp.Console.Presenters;

class UpdateMeetingEndPresenter : IPresenter
{

    private readonly MeetingBuilder _meetingBuilder;
    public UpdateMeetingEndPresenter(MeetingBuilder meetingBuilder)
    {
        _meetingBuilder = meetingBuilder;
    }
    public void Show()
    {
        Clear();
        WriteLine("Format: year-month-date T hours:minutes:seconds");
        WriteLine("Example: 2022-08-05T12:00:00 - means 5-th of August in 2022 year at 12 o`clock");
        WriteLine("Input The End date:");
    }

    public IPresenter Action()
    {
        while (true)
        {
            try
            {
                var endTime = ReadLine();
                _meetingBuilder.SetEnd(endTime);
                return new UpdateMeetingPresenter(DomainFactory.MeetingsService, _meetingBuilder);
            }
            catch (CalendarAppDomainException exc)
            {
                WriteLine("Incorrect input, please try again as it marked in tutorial upper" + exc.Message);
            }
        }
    }
}