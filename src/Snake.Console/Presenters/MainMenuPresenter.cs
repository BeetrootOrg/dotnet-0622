using Snake.Console.Presenters.Interfaces;

namespace Snake.Console.Presenters;

class MainMenuPresenter : IPresenter
{
    public IPresenter Action()
    {
        var key = ReadKey();
        switch (key.Key)
        {
            case (ConsoleKey.D1):
                return new GamePresenter();
            case (ConsoleKey.D2):
                return new HighscoresPresenter();
            case (ConsoleKey.D0):
                return null;
            default:
                return this;
        }
    }

    public void Show()
    {
        Clear();
        ForegroundColor = ConsoleColor.White;
        WriteLine("SNAKE");
        WriteLine("\t1. - Start");
        WriteLine("\t2. - Highscores");
        WriteLine("\t0. - Exit");        
    }
}