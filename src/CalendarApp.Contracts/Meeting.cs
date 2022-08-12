using System;

namespace CalendarApp.Contracts;

public record Meeting
{
	public string Name { get; init; }
	public DateTime Start { get; set; }
	public DateTime End { get; set; }
	public Room Room { get; init; }
}