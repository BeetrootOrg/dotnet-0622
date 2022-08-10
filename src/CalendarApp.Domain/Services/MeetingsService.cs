using System;
using System.Collections.Generic;
using System.Linq;
using CalendarApp.Contracts;
using CalendarApp.DataAccess.Repositories.Interfaces;
using CalendarApp.Domain.Exceptions;
using CalendarApp.Domain.Services.Interfaces;
using CalendarApp.Domain.Visitors;

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
	}

	public IEnumerable<Meeting> GetAllMeetings()
	{
		return _repository.GetAllMeetings();
	}

	public void UpdateMeetingsByName(string name, DateTime start, DateTime end)
	{
		var meetingVisitor = new UpdateMeetingVisitor();

		meetingVisitor.SetStart(start);
		meetingVisitor.SetEnd(end);

		var meetings = GetAllMeetings();

		var notUpdatedMeetings = meetings
			.Where(x => x.Name != name)
			.ToArray();

		var meetingsToUpdate = meetings
			.Where(x => x.Name == name)
			.ToList();

		var updatedMeetings = meetingsToUpdate
			.Select(x => x.Prototype())
			.ToList();

		updatedMeetings.ForEach(x =>
		{
			x.Accept(meetingVisitor);
		});

		var possibleAllMeetings = notUpdatedMeetings
			.Concat(meetingsToUpdate)
			.ToList();

		possibleAllMeetings.ForEach(meeting =>
		{
			var overlaps = possibleAllMeetings
				.Any(m => IsInsideTimeFrame(meeting.Timeframe.Start, m.Timeframe) ||
					IsInsideTimeFrame(m.Timeframe.Start, meeting.Timeframe));

			if (overlaps)
			{
				throw new CalendarAppDomainException("Meeting overlaps with another");
			}
		});

		meetingsToUpdate.ForEach(x =>
		{
			x.Accept(meetingVisitor);
		});

		_repository.Flush();
	}

	private static bool IsInsideTimeFrame(DateTime point, Timeframe timeframe) =>
		point >= timeframe.Start && point < timeframe.End;
}