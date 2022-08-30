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

	private readonly IList<Meeting> _meetings;

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
	public void DeleteMeeting(string meetingName)
	{
		_meetings.Remove(_meetings.First(x => x.Name == meetingName));
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
}