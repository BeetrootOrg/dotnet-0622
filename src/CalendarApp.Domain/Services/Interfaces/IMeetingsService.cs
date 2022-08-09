using System;
using System.Collections.Generic;
using CalendarApp.Contracts;

namespace CalendarApp.Domain.Services.Interfaces;

public interface IMeetingsService
{
	IEnumerable<Meeting> GetAllMeetings();
	void AddMeeting(Meeting meeting);
	void RemoveMeeting(Meeting meeting);
	void ChangeMeetingTime(Meeting meeting,Meeting oldMeeting);
}