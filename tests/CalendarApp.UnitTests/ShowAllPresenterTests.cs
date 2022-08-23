using System.Text;
using Bogus;
using CalendarApp.Console.Presenters;
using CalendarApp.Console.Presenters.Interfaces;
using CalendarApp.Console.Views.Interfaces;
using CalendarApp.Domain.Services.Interfaces;
using Moq;
using Shouldly;

namespace CalendarApp.UnitTests;

public class ShowAllPresenterTests
{
	private readonly Mock<IMeetingsService> _meetingService;
	private readonly Mock<IView> _view;
	private readonly IPresenter _presenter;

	public ShowAllPresenterTests()
	{
		_meetingService = new Mock<IMeetingsService>();
		_view = new Mock<IView>();

		_presenter = new ShowAllPresenter(_meetingService.Object, _view.Object);
	}

	[Fact]
	public void ShowShouldPrintCorrectMessage()
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
		_view.Verify(x => x.Print(string.Format("{0,-25}{1,-25}{2,-25}{3,-25}", "Name", "Start", "End", "Room")), Times.Once());

		foreach (var meeting in meetings)
		{
			_view.Verify(x => x.Print(string.Format("{0,-25}{1,-25}{2,-25}{3,-25}", meeting.Name,
				meeting.Timeframe.Start.ToString("s"),
				meeting.Timeframe.End.ToString("s"),
				meeting.Room.Name)), Times.Once());
		}

		_view.Verify(x => x.Print("Press any key to continue..."), Times.Once());
	}

	[Fact]
	public void ActionShouldWaitUntilKeyPressed()
	{
		// Arrange
		// Act
		var result = _presenter.Action();

		// Assert
		result.ShouldBeOfType<MainMenuPresenter>();
		_view.Verify(x => x.ReadKey(), Times.Once());
	}
} 