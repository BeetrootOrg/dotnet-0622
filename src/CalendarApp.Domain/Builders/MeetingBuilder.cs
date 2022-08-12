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

    public static void ValidateName(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new CalendarAppDomainException("Name should be not null or empty");
        }

    }
    public static DateTime ValidateParseDate(string dt)
    {
        if (!DateTime.TryParse(dt, out var parsedDate))
        {
            throw new CalendarAppDomainException("Invalid date time format");
        }
        return parsedDate;

    }

    public MeetingBuilder SetName(string name)
    {
        ValidateName(name);

        _name = name;
        return this;
    }

    public MeetingBuilder SetStart(string start)
    {

        _start = ValidateParseDate(start);
        return this;
    }

    public MeetingBuilder SetEnd(string end)
    {

        _end = ValidateParseDate(end);
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
            Start = _start.Value,
            End = _end.Value,
            Room = new Room
            {
                Name = _roomName
            },
        };
    }
}