using CalendarApp.Console.Presenters.Interfaces;
using CalendarApp.Domain.Builders;
using CalendarApp.Domain.Exceptions;
using CalendarApp.Domain.Services;
using CalendarApp.Domain.Services.Interfaces;

namespace CalendarApp.Console.Presenters;

class DeleteMeetingPresenter : IPresenter
{
    public IPresenter Action()
    {
        MeetingRemoverService removerService = new MeetingRemoverService();
        string meetingName = ReadLine();

        WriteLine(removerService.DeleteMeeting(meetingName));
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