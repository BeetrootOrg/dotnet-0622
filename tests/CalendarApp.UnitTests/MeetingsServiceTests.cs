using System;
using Bogus;
using CalendarApp.Contracts;
using CalendarApp.DataAccess.Repositories.Interfaces;
using CalendarApp.Domain.Services;
using CalendarApp.Domain.Services.Interfaces;
using Moq;
using Shouldly;

namespace CalendarApp.UnitTests;

public class MeetingsServiceTests
{
	private readonly Mock<IMeetingsRepository> _meetingsRepository;
	private readonly IMeetingsService _meetingsService;
	private readonly Faker<Meeting> _meetingFaker;

	public MeetingsServiceTests()
	{
		_meetingsRepository = new Mock<IMeetingsRepository>();
		_meetingsService = new MeetingsService(_meetingsRepository.Object);

		_meetingFaker = new Faker<Meeting>()
			.RuleFor(x => x.Name, f => f.Random.Word())
			.RuleFor(x => x.Timeframe, f =>
			{
				var start = f.Date.Past();

				return new Timeframe
				{
					Start = start,
					End = start.Add(f.Date.Timespan(TimeSpan.FromHours(2)))
				};
			})
			.RuleFor(x => x.Room, f => new Room
			{
				Name = f.Random.Word()
			});
	}

	[Fact]
	public void GetAllMeetingsShouldReturnThem()
	{
		// Arrange
		var meetings = _meetingFaker.GenerateBetween(5, 15);

		_meetingsRepository.Setup(x => x.GetAllMeetings())
			.Returns(meetings);

		// Act
		var result = _meetingsService.GetAllMeetings();

		// Assert
		result.ShouldBeSameAs(meetings);
	}
}