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
    public void DeleteMeetingsShouldDeleteThem()
    {
        // Arrange
        var meetings = Factory.MeetingFaker.Generate(1);

        _meetingsRepository.Setup(x => x.GetAllMeetings())
            .Returns(meetings);

        // Act
        _meetingsService.DeleteMeeting(meetings[0]);

        // Assert
        _meetingsRepository.Verify(x => x.DeleteMeeting(meetings[0]), Times.Once());
    }

    [Fact]
    public void UpdateMeetingShouldUpdateDateAndTimeIfNotOverlap()
    {
        // Arrange
        var meetings = Factory.MeetingFaker.GenerateBetween(5, 15);
        var meetingToUpdate = meetings[0];
        meetingToUpdate.Room = meetings[1].Room;
        meetingToUpdate.Timeframe = meetings[1].Timeframe;

        _meetingsRepository.Setup(x => x.GetAllMeetings())
            .Returns(meetings);

        Action action = () => _meetingsService.UpdateMeeting(meetingToUpdate, 0);

        // Assert
        action.ShouldThrow<CalendarAppDomainException>();
        _meetingsRepository.Verify(x => x.UpdateMeeting(meetingToUpdate, 0), Times.Never());
    }

    public void UpdateMeetingShouldThrowExceptionIfOverlap()
    {
        // Arrange
        var meetings = Factory.MeetingFaker.GenerateBetween(5, 15);
        var meetingToUpdate = meetings[0];
        meetingToUpdate.Timeframe = new Timeframe
        {
            Start = DateTime.Now,
            End = DateTime.Now.AddHours(2)
        };

        // Act 
        _meetingsService.UpdateMeeting(meetingToUpdate, 0);

        // Assert
        _meetingsRepository.Verify(x => x.UpdateMeeting(meetingToUpdate, 0), Times.Once());
    }
}