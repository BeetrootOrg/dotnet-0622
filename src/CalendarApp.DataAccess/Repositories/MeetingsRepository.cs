using System;
using System.Collections.Generic;
using CalendarApp.Contracts;
using CalendarApp.DataAccess.Repositories.Interfaces;

namespace CalendarApp.DataAccess.Repositories;

internal class MeetingsRepository : IMeetingsRepository
{
    public IEnumerable<Meeting> GetAllMeetings()
    {
        yield return new Meeting
        {
            Room = new Room
            {
                Name = "C# Room"
            },
            End = new DateTime(2022, 07, 25, 21, 00, 00),
            Start = new DateTime(2022, 07, 25, 19, 00, 00),
            Name = "Breaking Dependencies"
        };
        yield return new Meeting
        {
            Room = new Room
            {
                Name = "C# Room"
            },
            End = new DateTime(2022, 07, 27, 21, 00, 00),
            Start = new DateTime(2022, 07, 27, 19, 00, 00),
            Name = "Serialization"
        };
    }
}