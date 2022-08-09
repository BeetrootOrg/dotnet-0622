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
		if (Overlapsed(meetings, meeting))
		{
			throw new CalendarAppDomainException("Meeting overlaps with another");
		}
		_repository.AddMeeting(meeting);
	}

	public IEnumerable<Meeting> GetAllMeetings()
	{
		return _repository.GetAllMeetings();
	}

	public void ChangeMeetingTime(Meeting meeting, Meeting oldMeeting)
    {
		_repository.RemoveMeeting(oldMeeting);

		var meetings = GetAllMeetings();
		if (Overlapsed(meetings, meeting))
		{
			_repository.AddMeeting(oldMeeting);
			throw new CalendarAppDomainException("Meeting overlaps with another");
		}
		_repository.ChangeMeetingTime(meeting);
    }
	public void RemoveMeeting(Meeting meeting)
	{
		_repository.RemoveMeeting(meeting);
	}

	static bool IsInsideTimeFrame(DateTime point, Timeframe timeframe) =>
		point >= timeframe.Start && point < timeframe.End;

	static bool Overlapsed(IEnumerable<Meeting> meetings, Meeting meeting) =>
		meetings
		.Where(m => m.Room.Equals(meeting.Room))
		.Any(m => IsInsideTimeFrame(meeting.Timeframe.Start, m.Timeframe) ||
				IsInsideTimeFrame(m.Timeframe.Start, meeting.Timeframe));
}