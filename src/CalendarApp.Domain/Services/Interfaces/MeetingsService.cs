using CalendarApp.Contracts;
using CalendarApp.DataAccess.Repositories.Interfaces;
using CalendarApp.Domain.Services.Interface;

namespace CalendarApp.Domain.Services;

public class MeetingsService : IMeetingsService
{
    private readonly IMeetingRepository _repository;



    public IEnumerable<Meeting> GetAllMeetings()
    {
        return _repository.GetAllMeetings();
    }
}