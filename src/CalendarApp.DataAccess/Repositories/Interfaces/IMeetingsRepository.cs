using System.Collections.Generic;
using CalendarApp.Contracts;

namespace CalendarApp.DataAccess.Repositories.Interfaces;

public interface IMeetingsRepository
{
	IEnumerable<Meeting> GetAllMeetings();
	void AddMeeting(Meeting meeting);
	void DeleteMeetingByName(string name);
	void Flush();
}