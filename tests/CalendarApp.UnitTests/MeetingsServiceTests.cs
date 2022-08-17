using System;
using Bogus;
using CalendarApp.Contracts;
using CalendarApp.DataAccess.Repositories.Interfaces;
using CalendarApp.Domain.Exceptions;
using CalendarApp.Domain.Services;
using CalendarApp.Domain.Services.Interfaces;
using Moq;
using Shouldly;

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
		var meetings = Factory.MeetingFaker.GenerateBetween(5, 15);

		_meetingsRepository.Setup(x => x.GetAllMeetings())
			.Returns(meetings);

		// Act
		var result = _meetingsService.GetAllMeetings();

		// Assert
		result.ShouldBeSameAs(meetings);
	}

	[Fact]
	public void AddMeetingShouldAddItifNotOverlap()
	{
		// Arrange
		var meetings = Factory.MeetingFaker.GenerateBetween(5, 15);

		var meetingStart = Factory.CommonFaker.Date.Future().Add(TimeSpan.FromHours(2));
		var newMeeting = new Meeting
		{
			Name = Factory.CommonFaker.Random.Word(),
			Room = new Room
			{
				Name = Factory.CommonFaker.Random.Word(),
			},
			Timeframe = new Timeframe
			{
				Start = meetingStart,
				End = meetingStart.Add(Factory.CommonFaker.Date.Timespan())
			}
		};

		_meetingsRepository.Setup(x => x.GetAllMeetings())
			.Returns(meetings);

		// Act
		_meetingsService.AddMeeting(newMeeting);

		// Assert
		_meetingsRepository.Verify(x => x.AddMeeting(newMeeting), Times.Once());
	}

	[Fact]
	public void AddMeetingShouldRaiseExceptionIfOverlap()
	{
		// Arrange
		var meetings = Factory.MeetingFaker.GenerateBetween(5, 15);

		var meetingStart = Factory.CommonFaker.Date.Future().Add(TimeSpan.FromHours(2));
		var newMeeting = new Meeting
		{
			Name = Factory.CommonFaker.Random.Word(),
			Room = meetings[0].Room,
			Timeframe = meetings[0].Timeframe
		};

		_meetingsRepository.Setup(x => x.GetAllMeetings())
			.Returns(meetings);

		// Act
		Action action = () => _meetingsService.AddMeeting(newMeeting);

		// Assert
		action.ShouldThrow<CalendarAppDomainException>();
		_meetingsRepository.Verify(x => x.AddMeeting(newMeeting), Times.Never());
	}

	[Fact]
	public void UpdateMeetingShouldUpdateItifNotOverlap()
	{
		// Arrange
		var meetings = Factory.MeetingFaker.GenerateBetween(5, 15);

		var meetingStart = Factory.CommonFaker.Date.Future().Add(TimeSpan.FromHours(2));
		var newMeeting = new Meeting
		{
			Name = Factory.CommonFaker.Random.Word(),
			Room = new Room
			{
				Name = Factory.CommonFaker.Random.Word(),
			},
			Timeframe = new Timeframe
			{
				Start = meetingStart,
				End = meetingStart.Add(Factory.CommonFaker.Date.Timespan())
			}
		};

		_meetingsRepository.Setup(x => x.GetAllMeetings())
			.Returns(meetings);

		// Act
		_meetingsService.UpdateMeeting(newMeeting);

		// Assert
		_meetingsRepository.Verify(x => x.UpdateMeeting(newMeeting), Times.Once());
	}

		[Fact]
	public void DeleteMeetingShouldDeleteItIfItExist()
	{
		// Arrange
		var meetings = Factory.MeetingFaker.GenerateBetween(5, 15);

		int randomIndex = new Random().Next(meetings.Count);

		var randomMeetingName = meetings[randomIndex].Name;
		
		_meetingsRepository.Setup(x => x.GetAllMeetings())
			.Returns(meetings);

		// Act
		_meetingsService.DeleteMeeting(randomMeetingName);

		// Assert
		_meetingsRepository.Verify(x => x.DeleteMeeting(meetings[randomIndex]));
	}
}