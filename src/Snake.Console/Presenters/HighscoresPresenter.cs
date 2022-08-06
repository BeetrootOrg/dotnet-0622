using Snake.Console.Presenters.Interfaces;

namespace Snake.Console.Presenters;

class HighscoresPresenter : IPresenter
{
    public IPresenter Action()
    {
        ReadKey();
        return new MainMenuPresenter();
    }

    public void Show()
    {
        //_highScores = ReadScores(_highScoreFileName);
        Clear();
        WriteLine("TOP10:");
    }
}
