using CalendarApp.Console.Presenters.Interfaces;
using CalendarApp.Domain.Services.Interfaces;
using CalendarApp.Domain.Builders;
using CalendarApp.Domain.Exceptions;
using System.Linq;

namespace CalendarApp.Console.Presenters;

class UpdateMeetingPresenter : IPresenter
{
    private readonly IMeetingsService _meetingService;
    private readonly MeetingBuilder _meetingBuilder;

    public UpdateMeetingPresenter(IMeetingsService meetingsService, MeetingBuilder meetingBuilder)
    {
        _meetingService = meetingsService;
        _meetingBuilder = meetingBuilder;
    }
    public void Show()
    {
        // Just update
    }

    public IPresenter Action()
    {
        try
        {
            var buildMeeting = _meetingBuilder.Build();
            _meetingService.UpdateMeeting(buildMeeting);

            WriteLine($"Meeting {buildMeeting.Name} was successfully updated");
        }
        catch (CalendarAppDomainException exc)
        {
            WriteLine(exc.Message);
        }

        return new MainMenuPresenter();
    }
}