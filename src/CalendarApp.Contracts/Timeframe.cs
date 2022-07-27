using System;

namespace CalendarApp.Contracts;

public record Timeframe
{
	public DateTime Start { get; init; }
	public DateTime End { get; init; }
}
