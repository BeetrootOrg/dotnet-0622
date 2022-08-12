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
    public void Show()
    {
        Clear();
        WriteLine("Enter meeting name to delete:");
    }

    public IPresenter Action()
    {
        var name = ReadLine();
        if (_meetingService.DeleteMeeting(name))
            WriteLine("Meeting successfully deleted!");
        else
            WriteLine("The meeting could not be deleted");

        WriteLine("Press any key to continue...");
        ReadKey();

        return new MainMenuPresenter();

    }

}

