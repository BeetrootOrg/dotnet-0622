using System;
using System.Collections.Generic;
using CalendarApp.Contracts;

namespace CalendarApp.DataAccess.Repositories.Interfaces;

public interface IMeetingsRepository
{
    IEnumerable<Meeting> GetAllMeetings();
    void AddMeeting(Meeting meeting);

    bool DeleteMeeting(string name);

    bool UpdateMeeting(string name, DateTime start, DateTime end);
}