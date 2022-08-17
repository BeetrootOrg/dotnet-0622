namespace CalendarApp.Contracts;

public record Meeting
{
	public string Name { get; set; }
	public Timeframe Timeframe { get; set; }
	public Room Room { get; set; }
}