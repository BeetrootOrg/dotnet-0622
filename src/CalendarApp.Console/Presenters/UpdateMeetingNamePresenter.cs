using CalendarApp.Console.Presenters.Interfaces;
using CalendarApp.Domain.Services.Interfaces;
using CalendarApp.Domain.Builders;
using CalendarApp.Domain.Exceptions;
using System.Linq;

namespace CalendarApp.Console.Presenters;

class UpdateMeetingNamePresenter : IPresenter
{
    private readonly IMeetingsService _meetingService;
    private readonly MeetingBuilder _meetingBuilder;
    public UpdateMeetingNamePresenter(IMeetingsService meetingsService, MeetingBuilder meetingBuilder)
    {
        _meetingBuilder = meetingBuilder;
        _meetingService = meetingsService;
    }
    public void Show()
    {
        Clear();
        WriteLine("Write meeting name to update: ");
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

        var getMeeting = _meetingService.GetAllMeetings().First(x => x.Name == meetingName);

        _meetingBuilder.SetName(getMeeting.Name);
        _meetingBuilder.SetRoomName(getMeeting.Room.Name);
        return new UpdateMeetingStartPresenter(_meetingBuilder);
    }
}