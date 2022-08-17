namespace CalendarApp.Console.Presenters.interfaces;

internal interface IPresenter
{
    void Show();
    IPresenter Action();
}