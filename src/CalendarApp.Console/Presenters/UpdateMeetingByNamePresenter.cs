using System.Linq;
using CalendarApp.Console.Presenters.Interfaces;
using CalendarApp.Contracts;
using CalendarApp.Domain.Builders;
using CalendarApp.Domain.Services.Interfaces;

namespace CalendarApp.Console.Presenters;

internal class UpdateMeetingByNamePresenter : IPresenter
{
    private readonly MeetingBuilder _meetingBuilder;
    private readonly IMeetingsService _meetingService;

    public UpdateMeetingByNamePresenter(IMeetingsService meetingsService, MeetingBuilder meetingBuilder)
    {
        _meetingService = meetingsService;
        _meetingBuilder = meetingBuilder;
    }

    public IPresenter Action()
    {
        var meetingName = ReadLine();

        if (_meetingService.GetAllMeetings().Where(x => x.Name == meetingName).Count() == 0)
        {
            WriteLine($"There is no meeting with name '{meetingName}'");
        }
        else
        {
            var oldMeeting = _meetingService.GetAllMeetings().First(x => x.Name == meetingName);
            _meetingBuilder.SetName(oldMeeting.Name);
            _meetingBuilder.SetRoomName(oldMeeting.Room.Name);
            return new UpdateMeetingStartPresenter(_meetingBuilder);
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