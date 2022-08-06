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

    public void DeleteMeeting(Meeting meeting)
    {
        _meetings.Remove(meeting);
    }

    public IEnumerable<Meeting> GetAllMeetings()
	{
		return _meetings;
	}

    public Meeting UpdateMeeting(Meeting meeting)
    {
        throw new System.NotImplementedException();
    }
}