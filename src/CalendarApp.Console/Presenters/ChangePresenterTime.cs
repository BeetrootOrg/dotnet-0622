using System;
using CalendarApp.Console.Presenters.Interfaces;
using CalendarApp.Contracts;
using CalendarApp.Domain.Services.Interfaces;

namespace CalendarApp.Console.Presenters;

internal class ChangePresenterTime : IPresenter
{
    private readonly IMeetingsService _meetingService;

    public ChangePresenterTime(IMeetingsService meetingService)
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
                System.Console.WriteLine("Enter new meeting start date");
                DateTime startDate;
                if(!DateTime.TryParse(ReadLine(),out startDate))
                {
                    System.Console.WriteLine("Invalid start date");
                    break;
                }

                System.Console.WriteLine("Enter new meeting start date");
                DateTime endDate;
                if(!DateTime.TryParse(ReadLine(),out endDate))
                {
                    System.Console.WriteLine("Invalid end date");
                    break;
                }

                var newMeeting = new Meeting()
		        {
			        Name = meeting.Name,
			        Timeframe = new Timeframe {Start = startDate, End = endDate},
			        Room = meeting.Room
		        };
                
                try
                {
                    _meetingService.ChangeMeetingTime(newMeeting, meeting);
                    isPrinted = true;
                    System.Console.WriteLine("Meeting date was successfully changed");
                    break;
                }
                catch
                {
                    System.Console.WriteLine("Meeting overlaps with another");
                    isPrinted = true;
                }
                
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
		WriteLine("Enter meeting name to change meeting time: ");
    }
}