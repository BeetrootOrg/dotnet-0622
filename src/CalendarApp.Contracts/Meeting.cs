using System;

namespace CalendarApp.Contracts;

public record Meeting
{
	public string Name { get; init; }
	public DateTime Start { get; init; }
	public DateTime End { get; init; }
	public Room Room { get; init; }
}