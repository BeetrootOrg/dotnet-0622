using CalendarApp.Console.Presenters.Interfaces;
using CalendarApp.Domain.Builders;
using CalendarApp.Domain.Exceptions;
using DomainFactory = CalendarApp.Domain.Factory;

namespace CalendarApp.Console.Presenters;

internal class CreateMeetingRoomNamePresenter : IPresenter
{
	private readonly MeetingBuilder _meetingBuilder;

	public CreateMeetingRoomNamePresenter(MeetingBuilder meetingBuilder)
	{
		_meetingBuilder = meetingBuilder;
	}

	public IPresenter Action()
	{
		while (true)
		{
			try
			{
				var roomName = ReadLine();
				_meetingBuilder.SetRoomName(roomName);
				return new CreateMeetingPresenter(_meetingBuilder, DomainFactory.MeetingsService);
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
		WriteLine("Enter room name:");
	}
}