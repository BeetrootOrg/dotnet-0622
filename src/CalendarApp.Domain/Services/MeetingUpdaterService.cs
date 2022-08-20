using System;
using System.Collections.Generic;
using System.Linq;
using CalendarApp.Contracts;
using CalendarApp.DataAccess.Repositories.Interfaces;
using CalendarApp.Domain.Exceptions;
using CalendarApp.Domain.Services.Interfaces;

namespace CalendarApp.Domain.Services;

public class MeetingUpdaterService
{
    public static Meeting FindMeetingByName(string meetingName)
    {
        IEnumerable<Meeting> allMeetings = Factory.MeetingsService.GetAllMeetings();

        foreach (Meeting meeting in allMeetings)
        {
            if (meeting.Name.Equals(meetingName))
            {
                return meeting;
            }
        }

        return null;
    }

    public static Meeting FindMeetingByName(string meetingName, IMeetingsService meetingsService)
    {
        IEnumerable<Meeting> allMeetings = meetingsService.GetAllMeetings();

        foreach (Meeting meeting in allMeetings)
        {
            if (meeting.Name.Equals(meetingName))
            {
                return meeting;
            }
        }

        return null;
    }

    public void UpdateMeeting(Meeting meeting)
    {
        Factory.MeetingsService.UpdateMeeting(meeting);
    }
}