using CalendarApp.Contracts;
using System.Collections.Generic;

namespace CalendarApp.Domain.Services.Interface;

public interface IMeetingsService
{
    IEnumerable<Meeting> GetAllMeetings();
    
}    
