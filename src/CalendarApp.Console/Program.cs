using CalendarApp.Console.Presenters;
using CalendarApp.Console.Presenters.Interfaces;

IPresenter presenter = new MainMenuPresenter();
while (true)
{
    presenter.Show();
    presenter.Action();
    
}