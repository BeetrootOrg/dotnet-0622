using System;
using System.Collections.Generic;
using Bogus;
using CalendarApp.Contracts;
using CalendarApp.DataAccess.Repositories.Interfaces;
using CalendarApp.Domain.Builders;
using CalendarApp.Domain.Exceptions;
using CalendarApp.Domain.Services;
using CalendarApp.Domain.Services.Interfaces;
using Moq;
using Shouldly;

namespace CalendarApp.UnitTests;

public class MeetingRemoverTests
{
    private readonly Mock<IMeetingsRepository> _meetingsRepository;
    // private readonly Mock MeetingService 
    private readonly MeetingRemover _meetingRemover;

    public MeetingRemoverTests()
    {
        _meetingsRepository = new Mock<IMeetingsRepository>();
        _meetingRemover = new MeetingRemover();
    }

    [Fact]
    public void DeleteMeetingsShouldDeleteThem()
    {
        // Arrange
        var meetings = Factory.MeetingFaker.Generate(1);

        _meetingsRepository.Setup(x => x.AddMeeting(meetings[0]));
        _meetingsRepository.Setup(x => x.GetAllMeetings())
            .Returns(meetings);

        // Act
        var result = _meetingRemover.DeleteMeeting(meetings[0].Name);

        // Assert
        result.ShouldBe(1);
    }
}
//     [Fact]
//     public void AddMeetingShouldAddItifNotOverlap()
//     {
//         // Arrange
//         var meetings = Factory.MeetingFaker.GenerateBetween(5, 15);

//         var meetingStart = Factory.CommonFaker.Date.Future().Add(TimeSpan.FromHours(2));
//         var newMeeting = new Meeting
//         {
//             Name = Factory.CommonFaker.Random.Word(),
//             Room = new Room
//             {
//                 Name = Factory.CommonFaker.Random.Word(),
//             },
//             Timeframe = new Timeframe
//             {
//                 Start = meetingStart,
//                 End = meetingStart.Add(Factory.CommonFaker.Date.Timespan())
//             }
//         };

//         _meetingsRepository.Setup(x => x.GetAllMeetings())
//             .Returns(meetings);

//         // Act
//         _meetingsService.AddMeeting(newMeeting);

//         // Assert
//         _meetingsRepository.Verify(x => x.AddMeeting(newMeeting), Times.Once());
//     }

//     [Fact]
//     public void AddMeetingShouldRaiseExceptionIfOverlap()
//     {
//         // Arrange
//         var meetings = Factory.MeetingFaker.GenerateBetween(5, 15);

//         var meetingStart = Factory.CommonFaker.Date.Future().Add(TimeSpan.FromHours(2));
//         var newMeeting = new Meeting
//         {
//             Name = Factory.CommonFaker.Random.Word(),
//             Room = meetings[0].Room,
//             Timeframe = meetings[0].Timeframe
//         };

//         _meetingsRepository.Setup(x => x.GetAllMeetings())
//             .Returns(meetings);

//         // Act
//         Action action = () => _meetingsService.AddMeeting(newMeeting);

//         // Assert
//         action.ShouldThrow<CalendarAppDomainException>();
//         _meetingsRepository.Verify(x => x.AddMeeting(newMeeting), Times.Never());
//     }
// }