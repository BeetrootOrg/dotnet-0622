using System;
using CalendarApp.Contracts;
using CalendarApp.Contracts.Interfaces;
using CalendarApp.Domain.Exceptions;

namespace CalendarApp.Domain.Visitors;

public class UpdateMeetingVisitor : IVisitor<Meeting>
{
	public DateTime? Start { get; private set; }
	public DateTime? End { get; private set; }

	public void Visit(Meeting model)
	{
		model.Timeframe.Start = Start.Value;
		model.Timeframe.End = End.Value;
	}

	public void SetStart(DateTime start)
	{
		if (start <= DateTime.Now)
		{
			throw new CalendarAppDomainException("meeting cannot start in the past");
		}

		Start = start;
	}

	public void SetEnd(DateTime end)
	{
		if (end <= Start.Value)
		{
			throw new CalendarAppDomainException("meeting cannot end in the past or before start");
		}

		End = end;
	}
}