using System;
using System.Collections.Generic;
using CalendarApp.Contracts;
using CalendarApp.DataAccess.Repositories.Interfaces;

namespace CalendarApp.DataAccess.Repositories;

internal class MeetingsRepository : IMeetingsRepository
{
    private IList<Meeting> _meetings = new List<Meeting>();

    public void AddMeeting(Meeting meeting)
    {
        _meetings.Add(meeting);
    }

    public IEnumerable<Meeting> GetAllMeetings()
    {
        return _meetings;
    }

    public bool DeleteMeeting(string name)
    {
        for (int i = 0; i < _meetings.Count; i++)
        {
            if (_meetings[i].Name == name)
            {
                _meetings.RemoveAt(i);
                return true;
            }

        }
        return false;
    }
     public bool UpdateMeeting(string name, DateTime start, DateTime end)
     {
         for (int i = 0; i < _meetings.Count; i++)
        {
            if (_meetings[i].Name == name)
            {
                _meetings[i].Start = start;
                _meetings[i].End = end;

                return true;
            }

        }
        return false;

     }
}