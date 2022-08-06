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
        try
        {
            string meetingToDelete = ReadLine();
            _meetingRemover.DeleteMeeting(meetingToDelete);

            WriteLine("Meeting was successfully deleted!");
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
        WriteLine("Enter meeting name that you want to delete:");
    }
}