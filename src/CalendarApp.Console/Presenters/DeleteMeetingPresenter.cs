using CalendarApp.Console.Presenters.Interfaces;
using CalendarApp.Domain.Builders;
using CalendarApp.Domain.Exceptions;

namespace CalendarApp.Console.Presenters;

internal class DeleteMeetingPresenter : IPresenter
{
    public void Show()
    {
        Clear();
        WriteLine("Enter meeting name to delete:");
    }


   IPresenter Action()
    {
  
			try
			{
				var name = ReadLine();
				
			
			}
			catch (CalendarAppDomainException exc)
			{
				WriteLine(exc.Message);
			}

    }

}

