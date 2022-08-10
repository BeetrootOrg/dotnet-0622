using CalendarApp.Console.Presenters.Interfaces;
using CalendarApp.Domain.Builders;
using CalendarApp.Domain.Exceptions;

namespace CalendarApp.Console.Presenters;

internal class UpdateMeetingStartPresenter : IPresenter
{
    private string _name;
    public UpdateMeetingStartPresenter(string name)
    {
        _name = name;
    }
    public void Show()
    {
        Clear();
        WriteLine("Enter meeting new start date:");

    }
    public IPresenter Action()
    {
		while (true)
		{
			try
			{
				var dt = ReadLine();
				return new UpdateMeetingEndPresenter(_name,MeetingBuilder.ValidateParseDate(dt));
			}
			catch (CalendarAppDomainException exc)
			{
				WriteLine(exc.Message);
			}
		}
	}

}
