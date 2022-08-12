using System;
using System.Collections.Generic;
using CalendarApp.Contracts;

namespace CalendarApp.Domain.Services.Interfaces;

public interface IMeetingsService
{
    IEnumerable<Meeting> GetAllMeetings();
    void AddMeeting(Meeting meeting);

    bool UpdateMeeting(string name, DateTime start, DateTime end);

    bool DeleteMeeting(string name);


}