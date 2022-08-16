namespace CalendarApp.Console.Presenters.interfaces;

interface IPresenter
{
    void Show();
    IPresenter Action();
}