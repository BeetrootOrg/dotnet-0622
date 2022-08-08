using CalendarApp.Console.Presenters.Interfaces;
using CalendarApp.Domain.Services.Interfaces;
using CalendarApp.Domain.Builders;
using CalendarApp.Domain.Exceptions;
using System.Linq;

namespace CalendarApp.Console.Presenters;

class UpdateMeetingStartPresenter : IPresenter
{
    private readonly MeetingBuilder _meetingBuilder;
    public UpdateMeetingStartPresenter(MeetingBuilder meetingBuilder)
    {
        _meetingBuilder = meetingBuilder;

    }
    public void Show()
    {
        Clear();
        WriteLine("Format: year-month-date T hours:minutes:seconds");
        WriteLine("Example: 2022-08-05T12:00:00 - means 5-th of August in 2022 year at 12 o`clock");
        WriteLine("Input The start date:");
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
                WriteLine("Incorrect input, please try again as it marked in tutorial upper" + exc.Message);
            }
        }
    }
}