using CalendarApp.Console.Presenters.Interfaces;
using CalendarApp.Domain.Builders;
using CalendarApp.Domain.Exceptions;
using CalendarApp.Domain.Services.Interfaces;

namespace CalendarApp.Console.Presenters;

internal class UpdateMeetingPresenter : IPresenter
{
    private readonly MeetingBuilder _meetingBuilder;
    private readonly IMeetingsService _meetingService;
    public UpdateMeetingPresenter(MeetingBuilder meetingBuilder, IMeetingsService meetingService)
    {
        _meetingBuilder = meetingBuilder;
        _meetingService = meetingService;
    }

    public IPresenter Action()
    {
        try
        {
            var meeting = _meetingBuilder.Build();
            var index = new MeetingSearch().GetIndexOfMeeting(meeting.Name);
            _meetingService.UpdateMeeting(meeting, index);

            WriteLine("Meeting successfully updated!");
        }
        catch (CalendarAppDomainException exc)
        {
            WriteLine(exc.Message);
        }

        WriteLine("Press any key to continue...");
        ReadKey();

        return new MainMenuPresenter();
    }

    public void Show()
    {
        Clear();
    }
}
