using System.Collections.Generic;
using CalendarApp.Contracts;

namespace CalendarApp.DataAccess.Repositories.Interfaces;

interface IMeetingRepository
{
   IEnumerable<Meeting> GetAllMeetings();
}