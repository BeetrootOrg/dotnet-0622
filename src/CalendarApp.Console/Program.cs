using CalendarApp.Console.Presenters;
using CalendarApp.Console.Presenters.interfaces;

IPresenter presenter = new MainMenuPresenter();
while(presenter != null)
{
    presenter.Show();
    presenter = presenter.Action();
}