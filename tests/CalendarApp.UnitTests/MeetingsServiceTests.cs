using System;
using CalendarApp.Contracts;
using CalendarApp.DataAccess.Repositories.Interfaces;
using CalendarApp.Domain.Services;
using CalendarApp.Domain.Services.Interfaces;
using Moq;

namespace CalendarApp.UnitTests;

public class MeetingsServiceTests
{
	private readonly Mock<IMeetingsRepository> _meetingsRepository;
	private readonly IMeetingsService _meetingsService;

	public MeetingsServiceTests()
	{
		_meetingsRepository = new Mock<IMeetingsRepository>();
		_meetingsService = new MeetingsService(_meetingsRepository.Object);
	}

	[Fact]
	public void GetAllMeetingsShouldReturnThem()
	{
		// Arrange
		var meetings = new[]
		{
			new Meeting
			{
				Name = "meeting1",
				Room = new Room
				{
					Name = "room1"
				},
				Timeframe = new Timeframe
				{
					Start = DateTime.Now.Subtract(TimeSpan.FromDays(1)),
					End = DateTime.Now.Subtract(TimeSpan.FromHours(23)),
				}
			}
		};

		_meetingsRepository.Setup(x => x.GetAllMeetings())
			.Returns(meetings);

		// Act
		var result = _meetingsService.GetAllMeetings();

		// Assert
		Assert.Same(meetings, result);
	}
}