using CalendarApp.Console.Presenters.Interfaces;
using CalendarApp.Domain.Builders;
using CalendarApp.Domain.Exceptions;

namespace CalendarApp.Console.Presenters;

internal class UpdateMeetingNamePresenter : IPresenter{

    public IPresenter Action()
	{
		while (true)
		{
			try
			{
				var name = ReadLine();
				MeetingBuilder.ValidateName(name);
				return new UpdateMeetingStartPresenter(name);
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
		WriteLine("Enter meeting name to update:");
	}

}