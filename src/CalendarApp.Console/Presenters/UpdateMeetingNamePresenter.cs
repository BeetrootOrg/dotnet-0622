using CalendarApp.Console.Presenters.Interfaces;
using CalendarApp.Domain.Builders;
using CalendarApp.Domain.Exceptions;
using CalendarApp.Domain.Services.Interfaces;

namespace CalendarApp.Console.Presenters;

internal class UpdateMeetingNameAndRoomPresenter : IPresenter
{
    private readonly MeetingSearch _meetingSearch;
    private readonly MeetingBuilder _meetingBuilder;

    public UpdateMeetingNameAndRoomPresenter(MeetingSearch meetingSearch, MeetingBuilder meetingBuilder)
    {
        _meetingSearch = meetingSearch;
        _meetingBuilder = meetingBuilder;
    }

    public IPresenter Action()
    {
        try
        {
            var meetingToUpdate = ReadLine();
            _meetingSearch.Search(meetingToUpdate);
            _meetingBuilder.SetName(_meetingSearch.Search(meetingToUpdate).Name);
            _meetingBuilder.SetRoomName(_meetingSearch.Search(meetingToUpdate).Room.Name);

            return new UpdateMeetingStartPresenter(_meetingBuilder);
        }
        catch (CalendarAppDomainException exc)
        {
            WriteLine(exc.Message);
            WriteLine("Press any key to try again");
            ReadKey();
            return new MainMenuPresenter();
        }
    }

    public void Show()
    {
        Clear();
        WriteLine("Enter name of the meeting to update:");
    }
}
