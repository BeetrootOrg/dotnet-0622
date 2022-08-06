using Snake.Console.Presenters;
using Snake.Console.Presenters.Interfaces;

IPresenter presenter = new MainMenuPresenter();
while (presenter != null)
{
	presenter.Show();
	presenter = presenter.Action();
}