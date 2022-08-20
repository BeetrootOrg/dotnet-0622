using System;
using System.Collections.Generic;
using Bogus;
using CalendarApp.Contracts;
using CalendarApp.DataAccess.Repositories.Interfaces;
using CalendarApp.Domain.Exceptions;
using CalendarApp.Domain.Services;
using CalendarApp.Domain.Services.Interfaces;
using Moq;
using Shouldly;

namespace CalendarApp.UnitTests;

public class AnotherMeetingsServiceServiceTests
{
    private readonly Mock<IMeetingsRepository> _meetingsRepository;
    private readonly IMeetingsService _meetingsService;

    public AnotherMeetingsServiceServiceTests()
    {
        _meetingsRepository = new Mock<IMeetingsRepository>();
        _meetingsService = new MeetingsService(_meetingsRepository.Object);
    }

    [Fact]
    public void DeleteRandomMeetingTest()
    {
        // Arrange
        var meetings = Factory.MeetingFaker.GenerateBetween(5, 15);

        int meetingsListLenght = meetings.Count;

        _meetingsRepository.Setup(x => x.GetAllMeetings())
            .Returns(meetings);

        Random random = new Random((int)DateTime.Now.Ticks);
        int randomMeetingIndex = random.Next(0, meetingsListLenght - 1);

        // Act
        _meetingsService.DeleteMeeting(meetings[randomMeetingIndex]);

        // Assert
        _meetingsRepository.Verify(x => x.DeleteMeeting(meetings[randomMeetingIndex]), Times.Once());
    }

    [Fact]
    public void UpdateMeetingShouldUpdateMeetingIfNoOverlap()
    {
        // Arrange
        var meetings = Factory.MeetingFaker.GenerateBetween(5, 15);

        _meetingsRepository.Setup(x => x.GetAllMeetings())
            .Returns(meetings);

        Random random = new Random((int)DateTime.Now.Ticks);
        int randomMeetingIndex = random.Next(0, meetings.Count - 1);
        DateTime newMeetingStart = DateTime.Now.AddDays(7);
        Meeting meetingToUpdate = new Meeting
        {
            Name = meetings[randomMeetingIndex].Name,
            Room = meetings[randomMeetingIndex].Room,
            Timeframe = new Timeframe
            {
                Start = newMeetingStart,
                End = newMeetingStart.AddHours(2)
            }
        };

        // Act

        _meetingsService.UpdateMeeting(meetingToUpdate);

        // Assert
        _meetingsRepository.Verify(x => x.UpdateMeeting(meetingToUpdate, randomMeetingIndex), Times.Once());
    }

    [Fact]
    public void UpdateMeetingShouldThrowExceptionIfOverlap()
    {
        // Arrange
        var meetings = Factory.MeetingFaker.GenerateBetween(5, 15);

        _meetingsRepository.Setup(x => x.GetAllMeetings())
            .Returns(meetings);

        Random random = new Random((int)DateTime.Now.Ticks);
        int randomMeetingIndex = random.Next(0, meetings.Count - 1);
        Meeting meetingToUpdate = new Meeting
        {
            Name = meetings[randomMeetingIndex].Name,
            Room = randomMeetingIndex != 0 ? meetings[0].Room : meetings[1].Room,
            Timeframe = new Timeframe
            {
                Start = randomMeetingIndex != 0 ? meetings[0].Timeframe.Start : meetings[1].Timeframe.Start,
                End = randomMeetingIndex != 0 ? meetings[0].Timeframe.End : meetings[1].Timeframe.End
            }
        };

        // Act        
        Action action = () => _meetingsService.UpdateMeeting(meetingToUpdate);

        // Assert
        action.ShouldThrow<CalendarAppDomainException>();
        _meetingsRepository.Verify(x => x.UpdateMeeting(meetingToUpdate, randomMeetingIndex), Times.Never());
    }

}