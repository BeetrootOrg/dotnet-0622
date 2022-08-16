using CalendarApp.Console.Presenters;
using CalendarApp.Console.Presenters.interfaces;

IPresenter presenter = new MainMenuPresenter();
while(true)
{
    presenter.Show();
    presenter.Action();
}