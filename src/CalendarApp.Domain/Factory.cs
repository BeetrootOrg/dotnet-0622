using CalendarApp.Domain.Services;
using CalendarApp.Domain.Services.Interfaces;

using DataAccessFactory = CalendarApp.DataAccess.Factory;

namespace CalendarApp.Domain;

public static class Factory
{
    public static IMeetingsService MeetingsService =>new MeetingsService(DataAccessFactory.MeetingsRepository);
}