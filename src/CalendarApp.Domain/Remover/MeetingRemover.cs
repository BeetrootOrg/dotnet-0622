using System;
using CalendarApp.Contracts;
using CalendarApp.Domain.Exceptions;

namespace CalendarApp.Domain.Builders;

public class MeetingRemover
{
    public int DeleteMeeting(string meetingName)
    {
        Meeting meetingToDelete = null;
        int counter = 0;
        foreach (var item in Factory.MeetingsService.GetAllMeetings())
        {
            if (meetingName == item.Name)
            {
                meetingToDelete = item;
                counter++;
            }
        }
        Factory.MeetingsService.DeleteMeeting(meetingToDelete);
        return counter;
    }
}