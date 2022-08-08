using System;
using System.Collections.Generic;
using System.Linq;
using CalendarApp.Contracts;
using CalendarApp.DataAccess.Repositories.Interfaces;
using CalendarApp.Domain.Exceptions;
using CalendarApp.Domain.Services.Interfaces;

namespace CalendarApp.Domain.Services;

internal class MeetingsService : IMeetingsService
{
    private readonly IMeetingsRepository _repository;

    public MeetingsService(IMeetingsRepository repository)
    {
        _repository = repository;
    }

    public void AddMeeting(Meeting meeting)
    {
        var meetings = GetAllMeetings();

        var overlaps = meetings
            .Where(m => m.Room.Equals(meeting.Room))
            .Any(m => IsInsideTimeFrame(meeting.Timeframe.Start, m.Timeframe) ||
                IsInsideTimeFrame(m.Timeframe.Start, meeting.Timeframe));

        if (overlaps)
        {
            throw new CalendarAppDomainException("Meeting overlaps with another");
        }

        _repository.AddMeeting(meeting);

        static bool IsInsideTimeFrame(DateTime point, Timeframe timeframe) =>
            point >= timeframe.Start && point < timeframe.End;
    }

    public IEnumerable<Meeting> GetAllMeetings()
    {
        return _repository.GetAllMeetings();
    }

    public void DeleteMeeting(string meetingName)
    {
        _repository.DeleteMeeting(meetingName);
    }

    public void UpdateMeeting(Meeting meeting)
    {
        var meetings = GetAllMeetings();
        var meetingToUpdate = meetings.First(x => x.Name == meeting.Name);

        var overlaps = meetings
        .Where(m => m.Room.Equals(meeting.Room))
        .Any(m => IsInsideTimeFrame(meeting.Timeframe.Start, m.Timeframe) ||
            IsInsideTimeFrame(m.Timeframe.Start, meeting.Timeframe));

        if (overlaps)
        {
            throw new CalendarAppDomainException("Meeting overlaps with another");
        }


        _repository.UpdateMeeting(meeting);

        static bool IsInsideTimeFrame(DateTime point, Timeframe timeframe) =>
        point >= timeframe.Start && point < timeframe.End;
    }
}