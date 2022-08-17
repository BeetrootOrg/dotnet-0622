using System;
using CalendarApp.Contracts;
using CalendarApp.Domain.Exceptions;
using CalendarApp.Domain.Services;
using CalendarApp.Domain;
using CalendarApp.DataAccess.Repositories.Interfaces;
using CalendarApp.Domain.Services.Interfaces;

namespace CalendarApp.Domain.Builders;

public class MeetingUpdater
{
	private string _name;
	private DateTime? _start;
	private DateTime? _end;
	private string _roomName;

	

	public MeetingUpdater (Meeting meeting)
	{
		_name = meeting.Name;
		_start = meeting.Timeframe.Start;
		_end = meeting.Timeframe.End;
		_roomName = meeting.Room.Name;
		
	}
	
	public MeetingUpdater SetStart(string start)
	{
		if (!DateTime.TryParse(start, out var startTime))
		{
			throw new CalendarAppDomainException("Invalid date time format");
		}

		_start = startTime;
		return this;
	}

	public MeetingUpdater SetEnd(string end)
	{
		if (!DateTime.TryParse(end, out var endTime))
		{
			throw new CalendarAppDomainException("Invalid date time format");
		}

		_end = endTime;
		return this;
	}


	public Meeting Build()
	{
		if (string.IsNullOrWhiteSpace(_name) ||
			_start == null ||
			_end == null ||
			_start.Value >= _end.Value ||
			string.IsNullOrWhiteSpace(_roomName))
		{
			throw new CalendarAppDomainException("Invalid data for meeting builder");
		}

		return new Meeting
		{
			Name = _name,
			Timeframe = new Timeframe
			{
				Start = _start.Value,
				End = _end.Value,
			},
			Room = new Room
			{
				Name = _roomName
			},
		};
	}
}