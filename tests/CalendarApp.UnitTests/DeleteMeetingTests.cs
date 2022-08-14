using System;
using CalendarApp.Contracts;
using CalendarApp.DataAccess.Repositories.Interfaces;
using CalendarApp.Domain.Exceptions;
using CalendarApp.Domain.Services;
using CalendarApp.Domain.Services.Interfaces;
using Moq;
using Bogus;
using Shouldly;

namespace CalendarApp.UnitTests;
public class DeleteMeetingTests
{
    private readonly Mock<IMeetingsRepository> _meetingsRepository;
    private readonly IMeetingsService _meetingsService;

    public DeleteMeetingTests()
    {
        _meetingsRepository = new Mock<IMeetingsRepository>();
        _meetingsService = new MeetingsService(_meetingsRepository.Object);
    }

    public Meeting GenerateOneMeeting()
    {
        var meetingStart = Factory.CommonFaker.Date.Future().Add(TimeSpan.FromHours(2));
        return new Meeting
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
    }


    [Fact]
    public void DeleteMeetingShouldDeleteMeetingAtTheEnd()
    {
        // Arrange
        var meetings = Factory.MeetingFaker.GenerateBetween(5, 15);

        _meetingsRepository.Setup(x => x.GetAllMeetings()).Returns(meetings);

        var meetingToDelete = GenerateOneMeeting();
        _meetingsService.AddMeeting(meetingToDelete);

        // Act
        _meetingsService.DeleteMeeting(meetingToDelete.Name);
        var result = _meetingsService.GetAllMeetings();

        // Assert
        result.ShouldBeSameAs(meetings);

    }

    [Fact]
    public void DeleteMeetingShouldDeleteMeetingAtTheStart()
    {
        //Arrange
        var meetingToDelete = GenerateOneMeeting();
        var meetings = Factory.MeetingFaker.GenerateBetween(5, 15);
        meetings.Insert(0, meetingToDelete);

        _meetingsRepository.Setup(x => x.GetAllMeetings()).Returns(meetings);

        meetings.RemoveAt(0);

        //Act
        _meetingsService.DeleteMeeting(meetingToDelete.Name);
        var result = _meetingsService.GetAllMeetings();

        //Assert
        result.ShouldBeSameAs(meetings);
    }

    [Fact]
    public void DeleteMeetingShouldDeleteMeetingSomwhereInTheList()
    {
        //Arrange
        var random = new Random();
        var meetingToDelete = GenerateOneMeeting();
        var meetings = Factory.MeetingFaker.GenerateBetween(5, 15);

        var index = random.Next(0, meetings.Count);
        meetings.Insert(index, meetingToDelete);
        _meetingsRepository.Setup(x => x.GetAllMeetings()).Returns(meetings);
        meetings.RemoveAt(index);
        //Act
        _meetingsService.DeleteMeeting(meetingToDelete.Name);
        var result = _meetingsService.GetAllMeetings();
        //Assert
        result.ShouldBeSameAs(meetings);
    }

    [Fact]
    public void DeleteMeetingShouldDeleteNothing()
    {
        //Arrange
        var meetings = Factory.MeetingFaker.GenerateBetween(5, 15);
        _meetingsRepository.Setup(x => x.GetAllMeetings()).Returns(meetings);
        //Act
        _meetingsService.DeleteMeeting(Factory.CommonFaker.Random.Word());
        var result = _meetingsService.GetAllMeetings();
        //Assert
        result.ShouldBeSameAs(meetings);
    }
}