using CalendarApp.Console.Presenters.Interfaces;
using CalendarApp.Contracts;
using CalendarApp.Domain.Builders;
using CalendarApp.Domain.Exceptions;
using CalendarApp.Domain.Services;

namespace CalendarApp.Console.Presenters;

internal class UpdateMeetingUsingNamePresenter : IPresenter
{
    private readonly MeetingBuilder _meetingBuilder;

    public UpdateMeetingUsingNamePresenter(MeetingBuilder meetingBuilder)
    {
        _meetingBuilder = meetingBuilder;
    }

    public IPresenter Action()
    {
        string meetingName = ReadLine();
        Meeting meetingToUpdate = MeetingUpdaterService.FindMeetingByName(meetingName);

        if (meetingToUpdate is null)
        {
            WriteLine("No meeting with name you've entered!");
            WriteLine("Press any key to continue...");
            ReadKey();
            return new MainMenuPresenter();
        }

        _meetingBuilder.SetName(meetingToUpdate.Name);
        _meetingBuilder.SetRoomName(meetingToUpdate.Room.Name);

        return new UpdateMeetingStartPresenter(_meetingBuilder);
    }

    public void Show()
    {
        Clear();
        WriteLine("Enter meeting name:");
    }
} 