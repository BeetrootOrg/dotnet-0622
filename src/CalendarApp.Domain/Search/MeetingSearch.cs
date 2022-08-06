using System;
using System.Collections.Generic;
using CalendarApp.Contracts;
using CalendarApp.Domain.Exceptions;

namespace CalendarApp.Domain.Builders;

public class MeetingSearch
{
    public Meeting Search(string meetingName)
    {
        Meeting meetingSearched = null;
        foreach (var item in Factory.MeetingsService.GetAllMeetings())
        {
            if (meetingName == item.Name)
            {
                meetingSearched = item;
                break;
            }
        }
        if (meetingSearched == null)
        {
            throw new CalendarAppDomainException("The meeting you are looking for was not found");
        }
        
        // Factory.MeetingsService.UpdateMeeting(meetingSearched, index);
        return meetingSearched;
    }

    public int GetIndexOfMeeting(string meetingName)
    {
        Meeting searchedMeeting = Search(meetingName);
        List<Meeting> allMeetings = (List<Meeting>)Factory.MeetingsService.GetAllMeetings();
        return allMeetings.IndexOf(searchedMeeting);
    }
}