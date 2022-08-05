using System.Collections.Generic;
using CalendarApp.Contracts;

namespace CalendarApp.DataAccess.Repositories.Interfaces;

public interface IMeetingsRepository
{
	IEnumerable<Meeting> GetAllMeetings();
	void AddMeeting(Meeting meeting);
	void DeleteMeeting(string meetingName);
	void UpdateMeeting(Meeting meeting);
}