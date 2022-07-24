using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace SnakeGame;
public class NewGame
{
    private readonly EHeading _initialHeading = EHeading.Up;
    private DirectionMap _directionMap = Board.DirectionMap;

    private Board _board;
    public bool Lost { get; private set; } = false;
    public bool Quit { get; private set; } = false;

    public NewGame(int snakeLength = 5)
    {
        _board = new Board();
        var head = _board.Center;
        _board.Add(new Snake(head, InitBody(head, snakeLength - 1), _directionMap.Get(_initialHeading)));
        _board.AddFood();
        _board.Draw();
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
                    var direction = _directionMap.Get(input.KeyChar);
                    _board.DoTurn(direction);
                    Lost = _board.HasCollided;
                }
                catch
                {
                    Quit = input.Key == ConsoleKey.Escape;
                }
            }
            else
            {
                _board.DoTurn();
                Lost = _board.HasCollided;
            }
        }
    }

    private LinkedList<Cell> InitBody(Cell head, int bodyLength)
    {
        var body = new LinkedList<Cell>();
        var current = _board.BottomNeighbor(head);
        for (var i = 0; i < bodyLength; i++)
        {
            body.AddLast(current);
            current.SetBody(bodyLength - i);
            current = _board.BottomNeighbor(current);
        }
        return body;
    }
}