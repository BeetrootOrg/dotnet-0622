using CalendarApp.DataAccess.Repositories;
using CalendarApp.DataAccess.Repositories.Interfaces;

namespace CalendarApp.DataAccess;

public static class Factory
{
	public static IMeetingsRepository MeetingsRepository => new MeetingsRepository();
}