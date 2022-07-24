using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace SnakeGame;
public class SnakeGameApp
{
    private readonly int delayBetweenGames = 1500;

    public void Run()
    {
        var finished = false;
        while (!finished)
        {
            var game = new NewGame();
            game.Play();
            finished = game.Quit;
            if (game.Lost)
            {
                Console.WriteLine("\nYou lost.");
                Thread.Sleep(delayBetweenGames);
                Console.Clear();
            }
        }
    }
}
