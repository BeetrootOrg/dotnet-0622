using System;
using System.Collections.Generic;
using CalendarApp.Contracts;

namespace CalendarApp.Domain.Services.Interfaces;

public interface IMeetingsService
{
	IEnumerable<Meeting> GetAllMeetings();
	void AddMeeting(Meeting meeting);
	void UpdateMeetingsByName(string name, DateTime start, DateTime end);
}