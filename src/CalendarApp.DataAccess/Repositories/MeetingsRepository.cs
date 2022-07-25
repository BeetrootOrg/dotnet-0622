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
}