using System;
using System.Threading;

namespace ConsoleApp;

class SnakeGame
{
    private Field _field;
    private Timer _timer;

    private string _playerName;
    private bool _isOnRunnig = true;

    public SnakeGame()
    {
        _field = new Field();
    }

    public SnakeGame(Field filed)
    {
        _field = filed;
    }

    public void StartGame()
    {
        _timer = new Timer(Update, null, Timeout.InfiniteTimeSpan, TimeSpan.Zero);
        _timer.Change(TimeSpan.Zero, TimeSpan.FromMilliseconds(200));      
    }

    public void EndGame()
    {
        _timer.Dispose();      
    }

    public void Show()
    {
        _field.Render();      
        Console.CursorVisible = false;
    }
    
    private void Update(object state)
    {
        if (_isOnRunnig)
        {
            _isOnRunnig = _field.Update();
            Console.Clear();
            Show();
        } 
        else 
        {
            EndGame();
        }        
    }
    public bool IsOnRunnig() => _isOnRunnig;
    public int GetScore() => _field.GetScore();
    public int GetSize() => _field.GetSize();    
}