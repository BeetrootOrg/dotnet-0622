using System.Linq;
using CalendarApp.Console.Presenters.Interfaces;
using CalendarApp.Domain.Services.Interfaces;

namespace CalendarApp.Console.Presenters;

internal class DeleteMeetingPresenter : IPresenter
{
    private readonly IMeetingsService _meetingService;

    public DeleteMeetingPresenter(IMeetingsService meetingsService)
    {
        _meetingService = meetingsService;
    }

    public IPresenter Action()
    {
        var meetingName = ReadLine();

        if (_meetingService.GetAllMeetings().Any(x => x.Name != meetingName))

        {
            WriteLine($"There is not name: '{meetingName}'");
        }
        else
        {
            _meetingService.DeleteMeeting(meetingName);
            WriteLine($"Meeting with name '{meetingName}' was deleted");
        }

        WriteLine("Press any key to continue...");
        ReadKey();

        return new MainMenuPresenter();
    }

    public void Show()
    {
        Clear();
        WriteLine("Enter meeting name:");
    }
}