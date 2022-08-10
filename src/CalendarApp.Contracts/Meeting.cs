using CalendarApp.Contracts.Interfaces;

namespace CalendarApp.Contracts;

public record Meeting
{
	public string Name { get; set; }
	public Timeframe Timeframe { get; set; }
	public Room Room { get; set; }

	public void Accept(IVisitor<Meeting> visitor)
	{
		visitor.Visit(this);
	}

	public Meeting Prototype()
	{
		return new Meeting
		{
			Name = Name,
			Room = new Room
			{
				Name = Room.Name
			},
			Timeframe = new Timeframe
			{
				End = Timeframe.End,
				Start = Timeframe.Start
			}
		};
	}
}
