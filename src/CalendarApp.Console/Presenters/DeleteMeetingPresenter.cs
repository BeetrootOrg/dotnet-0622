using CalendarApp.Console.Presenters.Interfaces;
using CalendarApp.Domain.Services.Interfaces;
using CalendarApp.Domain.Exceptions;
using System.Linq;


namespace CalendarApp.Console.Presenters;
class DeleteMeetingPresenter : IPresenter
{
    private readonly IMeetingsService _meetingService;

    public DeleteMeetingPresenter(IMeetingsService meetingsService)
    {
        _meetingService = meetingsService;
    }
    public void Show()
    {
        Clear();
        WriteLine("Enter Meeting Name to delete: ");
    }

    public IPresenter Action()
    {
        static void pressAnyKey()
        {
            WriteLine("Press any key to continue...");
            ReadKey();
        }
        var meetingName = ReadLine();

        if (string.IsNullOrEmpty(meetingName))
        {
            WriteLine("Meeting Name shouldn`t be null or empty");
            pressAnyKey();
            return new MainMenuPresenter();
        }

        if (!_meetingService.GetAllMeetings().Where(x => x.Name == meetingName).Any())
        {
            WriteLine($"There`s no such meeting with name:  {meetingName}");
            pressAnyKey();
            return new MainMenuPresenter();
        }

        _meetingService.DeleteMeeting(meetingName);
        WriteLine($"Meeting with name '{meetingName}' was deleted");

        pressAnyKey();
        return new MainMenuPresenter();
    }
}