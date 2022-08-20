using CalendarApp.DataAccess.Repositories.Interfaces;

using Repository = CalendarApp.DataAccess.Repositories.MeetingsRepository;

namespace CalendarApp.DataAccess;

public static class Factory
{
	public static readonly IMeetingsRepository MeetingsRepository = Repository.Create();
}