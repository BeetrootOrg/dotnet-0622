using System;

namespace CalendarApp.Contracts;

public record Timeframe
{
	public DateTime Start { get; set; }
	public DateTime End { get; set; }
}
