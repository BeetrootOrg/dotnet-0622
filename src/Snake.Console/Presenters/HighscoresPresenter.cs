using Snake.Console.Presenters.Interfaces;
using Snake.Domain.Services.Interfaces;

namespace Snake.Console.Presenters;

class HighscoresPresenter : IPresenter
{
    private readonly IHighscoresService _highscoresService;
    public HighscoresPresenter(IHighscoresService highscoresService)
    {
        _highscoresService = highscoresService;
    }
    public IPresenter Action()
    {
        ReadKey();
        return new MainMenuPresenter();
    }

    public void Show()
    {
        Clear();
        WriteLine("TOP10:");
        var highscores = _highscoresService.GetAllHighscores();
        if (highscores.Count() == 0)
        {
            WriteLine("There is no any score yet");
        }
        else
        {
            int i=1;
            foreach(var highscore in highscores)
            {
                if (i==10)
                {
                    break;
                }
                WriteLine("{0,3} {1,-10} {2,3}", i+".", highscore.Name, highscore.Score);
                ++i;
            }
        }
    }
}
