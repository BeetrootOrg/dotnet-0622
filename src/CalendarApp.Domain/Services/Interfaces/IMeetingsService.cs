using System.Collections.Generic;
using CalendarApp.Contracts;

namespace CalendarApp.Domain.Services.Interfaces;

public interface IMeetingsService
{
    IEnumerable<Meeting> GetAllMeetings();
    void AddMeeting(Meeting meeting);

    bool DeleteMeeting(string name);
}