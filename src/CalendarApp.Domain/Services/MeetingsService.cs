using System.Collections.Generic;
using CalendarApp.Contracts;
using CalendarApp.DataAccess.Repositories.Interfaces;
using CalendarApp.Domain.Services.Interfaces;

namespace CalendarApp.Domain.Services;

internal class MeetingsService : IMeetingsService
{
	private readonly IMeetingsRepository _repository;

	public MeetingsService(IMeetingsRepository repository)
	{
		_repository = repository;
	}

	public void AddMeeting(Meeting meeting)
	{
		_repository.AddMeeting(meeting);
	}

	public IEnumerable<Meeting> GetAllMeetings()
	{
		return _repository.GetAllMeetings();
	}
}