using System;
using CalendarApp.Console.Presenters.Interfaces;
using CalendarApp.Domain.Builders;
using CalendarApp.Domain.Exceptions;
using DomainFactory = CalendarApp.Domain.Factory;

namespace CalendarApp.Console.Presenters;

internal class UpdateMeetingEndPresenter : IPresenter
{
    private string _name;
    private DateTime _startDate;

    public UpdateMeetingEndPresenter (string name, DateTime startDate)
    {
        _name = name;
        _startDate = startDate;
    }
   public IPresenter Action()
	{
		while (true)
		{
			try
			{
				var dt = ReadLine();
                var parsedDate = MeetingBuilder.ValidateParseDate(dt);
                if(DomainFactory.MeetingsService.UpdateMeeting(_name,_startDate,parsedDate))
                {
                     WriteLine("Your meeting was successfully updated!");

                }
                else
                {
                     WriteLine("Your meeting could not be updated!");

                }
				WriteLine("Press any key to continue...");
		        ReadKey();

		return new MainMenuPresenter();
			}
			catch (CalendarAppDomainException exc)
			{
				WriteLine(exc.Message);
			}
		}
        
	}

	public void Show()
	{
		Clear();
		WriteLine("Enter meeting new end date:");
	}
}
