using CalendarApp.Console.Presenters.Interfaces;
using CalendarApp.Domain.Services.Interfaces;

namespace CalendarApp.Console.Presenters;

internal class RemovePresenter : IPresenter
{
    private readonly IMeetingsService _meetingService;

    public RemovePresenter(IMeetingsService meetingService)
	{
		_meetingService = meetingService;
	}
    public IPresenter Action()
    {
        var name = ReadLine();
        bool isPrinted = false;
        foreach (var meeting in _meetingService.GetAllMeetings())
		{
            if(meeting.Name == name)
            {
                _meetingService.RemoveMeeting(meeting);
                isPrinted = true;
                System.Console.WriteLine("Meeting was successfully deleted");
                break;
            }
		}
        if(!isPrinted)
        {
            System.Console.WriteLine("Meeting does not exist");
        }
        System.Console.WriteLine("Press any key to continue...");
        ReadKey();
        return new MainMenuPresenter();
    }

    public void Show()
    {
        Clear();
		WriteLine("Enter meeting name to delete meeting: ");
    }
}