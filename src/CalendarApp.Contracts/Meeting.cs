namespace CalendarApp.Contracts;

public record Meeting
{
	public string Name { get; init; }
	public Timeframe Timeframe { get; set; }
	public Room Room { get; init; }
}
