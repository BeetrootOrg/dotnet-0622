using Snake.Console.Presenter.GameProcess;
using Snake.Console.Presenters.Interfaces;
using DomainFactory = Snake.Domain.Factory;



namespace Snake.Console.Presenters;

class GamePresenter : IPresenter
{
    private int _lastScore;
    public IPresenter Action()
    {
        return new PostGamePresenter(_lastScore, DomainFactory.HighscoresService);
    }

    public void Show()
    {
        Clear();
        var _snakeGame = new SnakeGame();
        _snakeGame.StartGame();
        while (_snakeGame.IsOnRunnig())
        {
            _lastScore = _snakeGame.GetScore();
        }
        Thread.Sleep(50);
    }

}
