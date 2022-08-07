using System;
using System.Collections.Generic;
using System.Linq;
using CalendarApp.Contracts;
using CalendarApp.DataAccess.Repositories.Interfaces;
using CalendarApp.Domain.Exceptions;
using CalendarApp.Domain.Services.Interfaces;

namespace CalendarApp.Domain.Services;

public class MeetingRemoverService : IMeetingRemoverService
{
    public string DeleteMeeting(string meetingName)
    {
        IMeetingsService meetingsService = Factory.MeetingsService;
        IList<Meeting> allMeetings = (IList<Meeting>)meetingsService.GetAllMeetings();

        int counter = 0;
        for (int i = 0; i < allMeetings.Count; i++)
        {
            if (allMeetings[i].Name.Equals(meetingName))
            {
                meetingsService.DeleteMeeting(allMeetings[i]);
                ++counter;
            }
        }

        if (counter.Equals(0))
        {
            return $"Meeting with name \"{meetingName}\" was not found";
        }

        return $"{counter} meeting(s) with name \"{meetingName}\" was(were) successfully deleted";
    }
} 