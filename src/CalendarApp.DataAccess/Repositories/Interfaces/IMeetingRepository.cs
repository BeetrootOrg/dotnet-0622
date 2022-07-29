using System.Collections.Generic;
using CalendarApp.Contracts;
namespace CalendarApp.DataAccess. Repositories.Interfaces;


public interface IMeetingRepository
{
    IEnumerable<Meeting>GetAllMeetings();
}