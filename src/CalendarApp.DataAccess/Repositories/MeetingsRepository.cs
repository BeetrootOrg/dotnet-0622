using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using CalendarApp.Contracts;
using CalendarApp.DataAccess.Repositories.Interfaces;
using Newtonsoft.Json;

namespace CalendarApp.DataAccess.Repositories;

internal class MeetingsRepository : IMeetingsRepository
{
	private const string Filename = "data.json";

	private IList<Meeting> _meetings;

	private MeetingsRepository(IList<Meeting> meetings)
	{
		_meetings = meetings;
	}

	public void AddMeeting(Meeting meeting)
	{
		_meetings.Add(meeting);
		var serialized = JsonConvert.SerializeObject(_meetings);
		File.WriteAllText(Filename, serialized);
	}

	public IEnumerable<Meeting> GetAllMeetings()
	{
		return _meetings;
	}

	public static MeetingsRepository Create()
	{
		IList<Meeting> meetings;
		if (!File.Exists(Filename))
		{
			meetings = new List<Meeting>();
		}
		else
		{
			var serialized = File.ReadAllText(Filename);
			meetings = JsonConvert.DeserializeObject<IList<Meeting>>(serialized);
		}

		return new MeetingsRepository(meetings);
	}
	public void RemoveMeeting(Meeting meeting)
	{
		List<Meeting> temp = new List<Meeting>(_meetings);
		temp.RemoveAll(n => n.Name == meeting.Name);
		
		var serialized = JsonConvert.SerializeObject(temp);
		File.WriteAllText(Filename, serialized);
		_meetings = temp;
	}

	public void ChangeMeetingTime(Meeting meeting)
    {
		_meetings.Add(meeting);
		var serialized = JsonConvert.SerializeObject(_meetings);
		File.WriteAllText(Filename, serialized);
    }
}