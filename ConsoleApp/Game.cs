using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace SnakeGame;
public class NewGame
{
    private readonly eHeading initialHeading = eHeading.Up;
    private DirectionMap directionMap = Board.DirectionMap;

    private Board board;
    public bool Lost { get; private set; } = false;
    public bool Quit { get; private set; } = false;

    public NewGame(int snakeLength = 5)
    {
        board = new Board();
        var head = board.Center;
        board.Add(new Snake(head, initBody(head, snakeLength - 1), directionMap.Get(initialHeading)));
        board.AddFood();
        board.Draw();
    }
    
    public void Play()
    {
        while (!Lost && !Quit)
        {
            ConsoleKeyInfo input;
            if (Console.KeyAvailable)
            {
                input = Console.ReadKey(true);
                try
                {
                    var direction = directionMap.Get(input.KeyChar);
                    board.DoTurn(direction);
                    Lost = board.HasCollided;
                }
                catch
                {
                    Quit = input.Key == ConsoleKey.Escape;
                }
            }
            else
            {
                board.DoTurn();
                Lost = board.HasCollided;
            }
        }
    }

    private LinkedList<Cell> initBody(Cell head, int bodyLength)
    {
        var body = new LinkedList<Cell>();
        var current = board.BottomNeighbor(head);
        for (var i = 0; i < bodyLength; i++)
        {
            body.AddLast(current);
            current.SetBody(bodyLength - i);
            current = board.BottomNeighbor(current);
        }
        return body;
    }
}