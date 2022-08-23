using System.Text;
using Bogus;
using CalendarApp.Console.Presenters;
using CalendarApp.Console.Presenters.Interfaces;
using CalendarApp.Console.Views.Interfaces;
using CalendarApp.Domain.Services.Interfaces;
using Moq;
using Shouldly;

namespace CalendarApp.UnitTests;

public class DeleteMeetingPresenterTests
{
	private readonly Mock<IMeetingsService> _meetingService;
    private readonly Mock<IView> _view;
	private readonly IPresenter _presenter;

	public DeleteMeetingPresenterTests()
	{
		_meetingService = new Mock<IMeetingsService>();

        _view = new Mock<IView>();

		_presenter = new DeleteMeetingPresenter(_meetingService.Object);
	}

	[Fact]
	public void DeleteExistingMeeting()
	{
		// Arrange
		var meetings = Factory.MeetingFaker.GenerateBetween(1, 2);

		_meetingService.Setup(x => x.GetAllMeetings())
			.Returns(meetings);

		var consoleRepresentation = new StringBuilder();

		_view.Setup(x => x.Print(It.IsAny<string>()))
			.Callback((string str) => consoleRepresentation.Append(str));

		_view.Setup(x => x.Clear())
			.Callback(() => consoleRepresentation.Clear());

		// Act
		_presenter.Show();

		// Assert
		consoleRepresentation.ToString().ShouldNotBeNullOrEmpty();
		_view.Verify(x => x.Clear(), Times.Once());
		_view.Verify(x => x.Print("Enter meeting name to delete:"), Times.Once());


	//	_view.Verify(x => x.Print("Press any key to continue..."), Times.Once());
	}
    public void DeleteNonExistingMeeting()
    {
        
    }
}