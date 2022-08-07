using System.Collections.Generic;
using CalendarApp.Contracts;

namespace CalendarApp.Domain.Services.Interfaces;

public interface IMeetingRemoverService
{
	string DeleteMeeting(string meetnigName);
} 