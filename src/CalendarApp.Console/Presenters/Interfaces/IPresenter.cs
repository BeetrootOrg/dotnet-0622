namespace CalendarApp.Console.Presenters.Interfaces;

internal interface IPresenter
{
    void Show();
    IPresenter Action();

}