using System.Collections.Generic;
using CalendarApp.Contracts;

namespace CalendarApp.Domain.Services.Interfaces;

public interface IMeetingsService
{
    IEnumerable<Meeting> GetAllMeetings();
    void AddMeeting(Meeting meeting);
    void DeleteMeeting(Meeting meeting);
    void UpdateMeeting(Meeting meeting, int index);
}