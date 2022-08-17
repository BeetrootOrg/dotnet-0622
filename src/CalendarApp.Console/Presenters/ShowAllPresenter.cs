using CalendarApp.Console.Presenters.interfaces;
using CalendarApp.Domain.Services.Interfaces;
using static System.Console;

namespace CalendarApp.Console.Presenters;

internal class ShowAllPresenter : IPresenter
{
    private readonly IMeetingsService _meetingService;

    public ShowAllPresenter(IMeetingsService meetingService)
    {
        _meetingService = meetingService;
    }
    public IPresenter Action()
    {
        ReadKey();
        return new MainMenuPresenter();
    }

    public void Show()
    {
        Clear();

        WriteLine("{0, -25}{1, -25}{2, -25}{3, -25}", "Name", "Start", "End", "Room");
        foreach (var meeting in _meetingService.GetAllMeetings())
        {
             WriteLine("{0, -25}{1, -25}{2, -25}{3, -25}", meeting.Name, 
             meeting.Start.ToString("s"), 
             meeting.End.ToString("s"), 
             meeting.Room.Name);
        }
        WriteLine("Press any key to continue...");

    }
}
