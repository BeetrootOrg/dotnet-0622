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
	public void DeleteMeetingShouldDeleteIfMeetingFound()
	{
		// Arrange
		var meetings = Factory.MeetingFaker.GenerateBetween(5, 15);
		Random random = new Random();
		var meetingForDelete = meetings[random.Next(0,meetings.Count)];
		var meetingsAfterDelete = meetings.Where(x => x!=meetingForDelete).ToList();
		_meetingsRepository.Setup(x => x.GetAllMeetings())
			.Returns(meetingsAfterDelete);

		// Act
		_meetingsService.DeleteMeeting(meetingForDelete.Name);
		var result = _meetingsService.GetAllMeetings();

		// Assert
		result.ShouldBeSameAs(meetingsAfterDelete);
	}

	[Fact]
	public void DeleteMeetingShouldNotDeleteIfMeetingNotFound()
	{
		// Arrange
		var meetings = Factory.MeetingFaker.GenerateBetween(5, 15);
		var allMeetingNames = "";
		foreach (var meeting in meetings)
			allMeetingNames += " " + meeting.Name;

		var meetingNameForDelete = Factory.MeetingFaker.Generate().Name;
		while (allMeetingNames.Contains(meetingNameForDelete))
			meetingNameForDelete = Factory.MeetingFaker.Generate().Name;

		_meetingsRepository.Setup(x => x.GetAllMeetings())
			.Returns(meetings);

		// Act
		_meetingsService.DeleteMeeting(meetingNameForDelete);
		var result = _meetingsService.GetAllMeetings();

		// Assert
		result.ShouldBeSameAs(meetings);
	}

		[Fact]
	public void UpdateMeetingShouldUpdateIfMeetingFound()
	{
		// Arrange
		var meetings = Factory.MeetingFaker.GenerateBetween(5, 15);
		Random random = new Random();
		var meetingForUpdate = meetings[random.Next(0,meetings.Count)];

		var newMeetingStart = Factory.CommonFaker.Date.Future().Add(TimeSpan.FromHours(2));
		var newMeeting = new Meeting
		{
			Name = meetingForUpdate.Name,
			Room = meetingForUpdate.Room,
			Timeframe = new Timeframe
			{
				Start = newMeetingStart,
				End = newMeetingStart.Add(Factory.CommonFaker.Date.Timespan())
			}
		};

		List<Meeting> meetingsAfterUpdete = new List<Meeting>();
		int index = meetings.IndexOf(meetingForUpdate);
		for (int i = 0; i<meetings.Count; i++)
		{
			if (i != index) 
			{
				meetingsAfterUpdete.Add(meetings[i]);
			}
			else
			{
				meetingsAfterUpdete.Add(newMeeting);
			}
		}

		_meetingsRepository.Setup(x => x.GetAllMeetings())
			.Returns(meetingsAfterUpdete);

		// Act
		_meetingsService.UpdateMeeting(meetingForUpdate);
		var result = _meetingsService.GetAllMeetings();

		// Assert
		result.ShouldBeSameAs(meetingsAfterUpdete);
	}

	[Fact]
	public void UpdateMeetingShouldNotUpdateIfMeetingNotFound()
	{
		// Arrange
		var meetings = Factory.MeetingFaker.GenerateBetween(5, 15);
		var allMeetingNames = "";
		foreach (var meeting in meetings)
			allMeetingNames += " " + meeting.Name;

		var meetingNameForUpdate = Factory.MeetingFaker.Generate().Name;
		while (allMeetingNames.Contains(meetingNameForUpdate))
			meetingNameForUpdate = Factory.MeetingFaker.Generate().Name;	

		var newMeetingStart = Factory.CommonFaker.Date.Future().Add(TimeSpan.FromHours(2));
		var meetingForUpdate = new Meeting
		{
			Name = meetingNameForUpdate,
			Room = meetings[0].Room,
			Timeframe = new Timeframe
			{
				Start = newMeetingStart,
				End = newMeetingStart.Add(Factory.CommonFaker.Date.Timespan())
			}
		};

		_meetingsRepository.Setup(x => x.GetAllMeetings())
			.Returns(meetings);

		// Act
		Action action = () => _meetingsService.UpdateMeeting(meetingForUpdate);

		// Assert
		action.ShouldThrow<InvalidOperationException>();
		_meetingsRepository.Verify(x => x.UpdateMeeting(meetingForUpdate), Times.Never());
	}
}