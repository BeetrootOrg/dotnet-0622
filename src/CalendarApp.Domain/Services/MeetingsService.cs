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

    public void DeleteMeeting(Meeting meeting)
    {
        _repository.DeleteMeeting(meeting);
    }

    public IEnumerable<Meeting> GetAllMeetings()
	{
		return _repository.GetAllMeetings();
	}

    public void UpdateMeeting(Meeting meeting)
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

        Meeting meetingToUpdate = MeetingUpdaterService.FindMeetingByName(meeting.Name, this);
		List<Meeting> allMeetings = (List<Meeting>)GetAllMeetings();

		int indexOfMeetingToUpdate = allMeetings.IndexOf(meetingToUpdate);

		_repository.UpdateMeeting(meeting, indexOfMeetingToUpdate);

		static bool IsInsideTimeFrame(DateTime point, Timeframe timeframe) =>
			point >= timeframe.Start && point < timeframe.End;
    }
}