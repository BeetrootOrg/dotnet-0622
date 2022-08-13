using CalendarApp.Console.Presenters.Interfaces;
using CalendarApp.Domain.Builders;
using CalendarApp.Domain.Exceptions;
using DomainFactory = CalendarApp.Domain.Factory;

namespace CalendarApp.Console.Presenters;

internal class UpdateMeetingRoomPresenter : IPresenter
{
	private readonly MeetingBuilder _meetingBuilder;

	public UpdateMeetingRoomPresenter(MeetingBuilder meetingBuilder)
	{
		_meetingBuilder = meetingBuilder;
	}

	public IPresenter Action()
	{
		while (true)
		{
			try
			{
				var newRoom = ReadLine();
				_meetingBuilder.SetRoomName(newRoom);
				return new UpdateMeetingPresenter(DomainFactory.MeetingsService, _meetingBuilder);
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
		WriteLine("Enter new meeting room name:");
	}
}