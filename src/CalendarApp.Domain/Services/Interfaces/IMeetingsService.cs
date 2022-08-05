using System.Collections.Generic;
using CalendarApp.Contracts;

namespace CalendarApp.Domain.Services.Interfaces;

public interface IMeetingsService
{
    IEnumerable<Meeting> GetAllMeetings();
    void AddMeeting(Meeting meeting);
    void DeleteMeeting(string meetingName);
    void UpdateMeeting(Meeting meeting);
}