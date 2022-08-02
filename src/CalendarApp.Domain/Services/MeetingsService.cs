using System.Collections.Generic;
using CalendarApp.Contracts;
using CalendarApp.DataAccess.Repositories.Interfaces;
using CalendarApp.Domain.Services.Interfaces;
using System.Linq;

namespace CalendarApp.Domain.Services;

internal class MeetingsService : IMeetingsService
{
	private readonly IMeetingsRepository _repository;

	public MeetingsService(IMeetingsRepository repository)
	{
		_repository = repository;
	}

	public Meeting GetMeetingByName (string name)
	{
		var list = _repository.GetAllMeetings();
		return list.First( x => x.Name == name);
	}
	public void AddMeeting(Meeting meeting)
	{
		_repository.AddMeeting(meeting);
	}

	public void UpdateMeeting(Meeting meeting)
	{	
		_repository.UpdateMeeting(meeting);
		GetAllMeetings();
	}
		public void DeleteMeeting(string name)
	{	
		var list = _repository.GetAllMeetings();
		var meeting = list.First( x => x.Name == name);
		_repository.DeleteMeeting(meeting);
	}

	public IEnumerable<Meeting> GetAllMeetings()
	{
		return _repository.GetAllMeetings();
	}
}