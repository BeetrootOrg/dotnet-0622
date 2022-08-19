using CalendarApp.Console.Presenters.Interfaces;
using CalendarApp.Domain.Builders;
using CalendarApp.Domain.Exceptions;
using CalendarApp.Domain.Services.Interfaces;

namespace CalendarApp.Console.Presenters;

internal class DeleteMeetingPresenter : IPresenter
{
    private readonly MeetingRemover _meetingRemover;

    public DeleteMeetingPresenter(MeetingRemover meetingRemover)
    {
        _meetingRemover = meetingRemover;
    }

    public IPresenter Action()
    {
        string meetingToDelete = ReadLine();
        int deletedMeetings = _meetingRemover.DeleteMeeting(meetingToDelete);

        WriteLine($"{deletedMeetings} meetings were deleted");

        WriteLine("Press any key to continue...");
        ReadKey();

        return new MainMenuPresenter();
    }

    public void Show()
    {
        Clear();
        WriteLine("Enter meeting name that you want to delete:");
    }
}