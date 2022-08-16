using System;

namespace CalendarApp.Contracts;

public record Meeting(string Name, DateTime Start, DateTime End, Room room);