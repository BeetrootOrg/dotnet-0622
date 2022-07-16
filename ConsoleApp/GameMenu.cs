using System;
using System.Text;
using System.Threading;

namespace ConsoleApp;

class GameMenu
{
    private SnakeGame _snakeGame;
    private int _lastScore;
    private string _highScoreFileName = "HighScores.csv";
    private List<(int, string)> _highScores;

    public void Run()
    {
        ShowMenu();
    }

    public void ShowMenu()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("SNAKE");
        Console.WriteLine("\t1. - Start");
        Console.WriteLine("\t2. - Highscores");
        Console.WriteLine("\t3. - Exit");
        var key = Console.ReadKey();
        switch (key.Key)
        {
            case (ConsoleKey.D1):
                Start();
                break;
            case (ConsoleKey.D2):
                ShowHighscores();
                break;
            case (ConsoleKey.D3):
                Exit();
                break;
            default:
                ShowMenu();
                break;
        }
    }   

    private void Start()
    {
        _snakeGame = new SnakeGame();
        _snakeGame.StartGame();
        while (_snakeGame.IsOnRunnig())
        {
            _lastScore = _snakeGame.GetScore();
        }
        Thread.Sleep(50);
        PostGameMessage();
        ShowMenu();
    }
    
    private void ShowHighscores()
    {        
        _highScores = ReadScores(_highScoreFileName);
        Console.Clear();
        Console.WriteLine("TOP10:");

        if (_highScores.Count == 0)
        {
            Console.WriteLine("There is no any score yet");
        }
        else
        {
            for (int i = 0; i < _highScores.Count; i++)
            {
                Console.WriteLine("{0,3} {1,-10} {2,3}", i+1+".", _highScores[i].Item2, _highScores[i].Item1);
            }
        }        
        
        Console.ReadKey();
        ShowMenu();
    }

    private void Exit()
    {
        Console.Clear();
        Environment.Exit(0);
    }

    private void PostGameMessage()
    {
        _highScores = ReadScores(_highScoreFileName);
        int size = _snakeGame.GetSize();
        Console.ForegroundColor = ConsoleColor.White;
        if (_highScores.Count < 10 || _highScores.Last().Item1 < _lastScore)
        {            
            Console.SetCursorPosition(1, size/2-3);
            Console.Write("+-----------+");
            Console.SetCursorPosition(1, size/2-2);
            Console.Write("|    NEW    |");
            Console.SetCursorPosition(1, size/2-1);
            Console.Write("| HIGHSCORE |");
            Console.SetCursorPosition(1, size/2);
            Console.Write("|ENTER NAME:|");
            Console.SetCursorPosition(1, size/2+1);
            Console.Write("|           |");
            Console.SetCursorPosition(1, size/2+2);
            Console.Write("+-----------+");

            Console.SetCursorPosition(2, size/2+1);
            string playerName = Console.ReadLine();
            AddRecord(playerName, _lastScore);
        }
        else
        {
            Console.SetCursorPosition(1, size/2-2);
            Console.Write("+-----------+");
            Console.SetCursorPosition(1, size/2-1);
            Console.Write($"| GAME OVER |");
            Console.SetCursorPosition(1, size/2);
            if (_lastScore / 10 == 0) 
            {
                Console.Write($"| SCORE:  {_lastScore} |");
            }
            else
            {
                Console.Write($"| SCORE: {_lastScore} |");
            }
            Console.SetCursorPosition(1, size/2+1);
            Console.Write("+-----------+");
            Console.ReadKey();
        }
    }

    private void AddRecord(string playerName, int score)
    {
        _highScores = ReadScores(_highScoreFileName);
           
        if (_highScores.Count < 10) 
        { 
            _highScores.Add((score,playerName));
        }
        else if (_highScores[9].Item1 < score)
        {
            _highScores.Add((score,playerName));
        }
        
        _highScores.Sort();
        int index = 0;
        var csvBuilder = new StringBuilder();
        for (int i = _highScores.Count-1; i >= 0; i--)
        {
            if (index >= 10) break;
            csvBuilder.AppendLine($"{_highScores[i].Item2},{_highScores[i].Item1}");
            index++;
        }

        File.WriteAllText(_highScoreFileName, csvBuilder.ToString());
    }

    private List<(int, string)> ReadScores(string file)
    {
        List<(int, string)> highScores = new List<(int, string)>();

        using (var stream = File.Open(file, FileMode.OpenOrCreate)) 
        {
            var streamReader = new StreamReader(stream, Encoding.UTF8);
            string content = streamReader.ReadToEnd();
            foreach(var line in content.Split("\n"))
            {
                var item = line.Split(",");
                if (line != "") highScores.Add((Int32.Parse(item[1]), item[0]));
            }
        }
        return highScores;
    } 
}