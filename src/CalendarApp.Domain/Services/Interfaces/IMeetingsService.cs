using CalendarApp.Contracts;

namespace CalendarApp.Domain.Services.Interface;

public interface IMeetingsService
{
    IEnumerable<Meeting> GetAll();
    
}    
