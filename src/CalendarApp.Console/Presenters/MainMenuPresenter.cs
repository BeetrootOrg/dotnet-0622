using System;
using CalendarApp.Console.Presenters.Interfaces;
using CalendarApp.Console.Views;
using CalendarApp.Domain.Builders;
using DomainFactory = CalendarApp.Domain.Factory;

namespace CalendarApp.Console.Presenters;

internal class MainMenuPresenter : IPresenter
{
    public IPresenter Action()
    {
        var key = ReadKey();

        switch (key.Key)
        {
            case ConsoleKey.D1:
                return new ShowAllPresenter(DomainFactory.MeetingsService, new ConsoleView());
            case ConsoleKey.D2:
                return new CreateMeetingNamePresenter(new MeetingBuilder());
            case ConsoleKey.D3:
                return new DeleteMeetingPresenter(DomainFactory.MeetingsService);
            case ConsoleKey.D4:
                return new UpdateMeetingNamePresenter(DomainFactory.MeetingsService, new MeetingBuilder());
            case ConsoleKey.D0:
                return null;
            default:
                return this;
        }
    }

    public void Show()
    {
        Clear();

        WriteLine("CalendarApp");
        WriteLine();
        WriteLine("1 - Show all meetings");
        WriteLine("2 - Add meeting");
        WriteLine("3 - Delete Meeting");
        WriteLine("4 - Update meeting");
        WriteLine("0 - Exit");
    }
}