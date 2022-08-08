using System;
using CalendarApp.Contracts;
using CalendarApp.Domain.Exceptions;

namespace CalendarApp.Domain.Builders;

public class MeetingBuilder
{
    private string _name;
    private DateTime? _start;
    private DateTime? _end;
    private string _roomName;

    public MeetingBuilder SetName(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new CalendarAppDomainException("Name should be not null or empty");
        }

        _name = name;
        return this;
    }

    public MeetingBuilder SetStart(string start)
    {
        if (!DateTime.TryParse(start, out var startTime))
        {
            throw new CalendarAppDomainException("Invalid date time format");
        }

        _start = startTime;
        return this;
    }

    public MeetingBuilder SetEnd(string end)
    {
        if (!DateTime.TryParse(end, out var endTime))
        {
            throw new CalendarAppDomainException("Invalid date time format");
        }

        _end = endTime;
        return this;
    }

    public MeetingBuilder SetRoomName(string roomName)
    {
        if (string.IsNullOrWhiteSpace(roomName))
        {
            throw new CalendarAppDomainException("Room name should be not null or empty");
        }

        _roomName = roomName;
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