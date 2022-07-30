using System.Collections.Generic;
using CalendarApp.Contracts;

namespace CalendarApp.Domain.Services.Interfaces;

public interface IMeetingsService
{
	IEnumerable<Meeting> GetAllMeetings();
	void AddMeeting (Meeting meeting);
	void DeleteMeeting (string name);
	void UpdateMeeting (Meeting meeting);
	Meeting GetMeetingByName (string name);
}