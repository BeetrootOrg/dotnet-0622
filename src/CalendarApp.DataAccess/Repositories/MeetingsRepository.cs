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

	public void AddMeeting(Meeting meeting)
	{
		var meetings = GetAllMeetings();
		var newMeetings = meetings.Append(meeting);
		var serialized = JsonConvert.SerializeObject(newMeetings);
		File.WriteAllText(Filename, serialized);
	}

	public IEnumerable<Meeting> GetAllMeetings()
	{
		if (!File.Exists(Filename))
		{
			return Enumerable.Empty<Meeting>();
		}

		var serialized = File.ReadAllText(Filename);
		return JsonConvert.DeserializeObject<IEnumerable<Meeting>>(serialized);
	}
}