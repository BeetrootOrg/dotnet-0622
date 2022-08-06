using System;
using CalendarApp.Contracts;
using CalendarApp.Domain.Exceptions;

namespace CalendarApp.Domain.Builders;

public class MeetingRemover
{
    public void DeleteMeeting(string meetingName)
    {
        Meeting meetingToDelete = null;
        foreach (var item in Factory.MeetingsService.GetAllMeetings())
        {
            if (meetingName == item.Name)
            {
                meetingToDelete = item;
                break; // method deletes the first found meeting with the requested name
            }
        }
        if(meetingToDelete == null)
        {
            throw new CalendarAppDomainException("The meeting you are looking for was not found");
        }
        Factory.MeetingsService.DeleteMeeting(meetingToDelete);
    }
}
