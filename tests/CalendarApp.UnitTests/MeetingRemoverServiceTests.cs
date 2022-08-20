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
using CalendarApp.Domain;

namespace CalendarApp.UnitTests;

public class MeetingRemoverServiceTests
{
    private readonly Mock<IMeetingsRepository> _meetingsRepository;
    private readonly MeetingRemoverService _meetingRemover;

    public MeetingRemoverServiceTests()
    {
        _meetingRemover = new MeetingRemoverService();
        _meetingsRepository = new Mock<IMeetingsRepository>();
    }

    [Fact]
    public void DeleteMeetingTest()
    {
        // Arrange
        Meeting meetingToDelete = Factory.MeetingFaker.Generate();
        String meetingName = meetingToDelete.Name;
        
        _meetingsRepository.Setup(x => x.GetAllMeetings())
			.Returns(new List<Meeting> {meetingToDelete});

        // Act        
        string returnedString = _meetingRemover.DeleteMeeting(meetingName);
        
        System.Console.WriteLine(returnedString);
        // Assert
        _meetingsRepository.Verify(x => x.DeleteMeeting(meetingToDelete), Times.Once());

    }

}