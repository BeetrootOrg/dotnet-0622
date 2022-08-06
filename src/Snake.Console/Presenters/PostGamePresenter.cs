using Snake.Console.Presenters.Interfaces;
using Snake.Domain.Services.Interfaces;
using Snake.Contracts;

namespace Snake.Console.Presenters;

class PostGamePresenter : IPresenter
{
    private readonly int _lastScore;
    private readonly IHighscoresService _highscoresService;
    public PostGamePresenter(int lastScore, IHighscoresService highscoresService)
    {
        _highscoresService = highscoresService;
        _lastScore = lastScore;
    }
    public IPresenter Action()
    {
        var name = ReadLine();        

        _highscoresService.AddHighscore(new Highscore{
            Name = name,
            Score = _lastScore
        });
        
        return new MainMenuPresenter();
    }

    public void Show()
    {
        Clear();
        WriteLine($"Score: {_lastScore}");
        Write("Enter your name: ");
    }
}
