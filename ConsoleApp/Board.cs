using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace SnakeGame;
public class Board
{
    public static DirectionMap DirectionMap { get; } = new DirectionMap();

    private readonly string _instructions = "How to Play: Avoid hitting walls or yourself. Grow by eating food (Y). Highest length wins.";
    private readonly string _commandBase = "Commands: {0}, Esc: Quit\n";
    private readonly string _lengthBase = "Length: {0}\n";

    private Cell[,] _grid;
    private Random _random = new Random();
    private int _leftEdgeX => 0;
    private int _rightEdgeX => Width - 1;
    private int _topEdgeY => 0;
    private int _bottomEdgeY => Height - 1;

    public Snake Snake { get; private set; }
    public int Height { get; private set; }
    public int Width { get; private set; }
    public Cell Current => Snake.Head;
    public Cell Center => Get(Width / 2, Height / 2);
    public Cell Food { get; private set; }
    public bool HasCollided { get; private set; }

    public Board(int width = 90, int height = 25)
    {
        Width = width;
        Height = height;
        _grid = new Cell[Width, Height];
        InitGrid();
    }

    public void DoTurn()
    {
        DoTurn(Snake.Direction, GetDestination(Snake.Direction));
    }

    public void DoTurn(Direction direction)
    {
        DoTurn(direction, GetDestination(direction));
    }

    public void Draw()
    {
        Console.SetCursorPosition(0, 0);
        Console.WriteLine(ToString());
    }

    public void Add(Snake snake) => Snake = snake;
    public void AddFood() => RandomCell().SetFood();

    public Cell TopNeighbor(Cell cell) => _grid[cell.X, cell.Y - 1];
    public Cell RightNeighbor(Cell cell) => _grid[cell.X + 1, cell.Y];
    public Cell BottomNeighbor(Cell cell) => _grid[cell.X, cell.Y + 1];
    public Cell LeftNeighbor(Cell cell) => _grid[cell.X - 1, cell.Y];

    public override string ToString()
    {
        var sb = new StringBuilder();
        for (int y = 0; y < Height; y++)
        {
            for (int x = 0; x < Width; x++)
            {
                sb.Append(_grid[x, y].Value);
            }
            sb.Append("\n");
        }
        sb.AppendFormat(_lengthBase, Snake.Length);
        sb.AppendLine(_instructions);
        sb.AppendFormat(_commandBase, DirectionMap.ToString());
        return sb.ToString();
    }

    private Cell Get(int x, int y) => _grid[x, y];

    private void Add(Cell cell) => _grid[cell.X, cell.Y] = cell;

    private bool IsBorder(Cell cell) => cell.X == _leftEdgeX || cell.X >= _rightEdgeX
                                     || cell.Y == _topEdgeY || cell.Y >= _bottomEdgeY;

    private void DoTurn(Direction direction, Cell target)
    {
        if (IsLegalMove(direction, target))
        {
            Snake.Move(direction, target);

            if (Snake.HasEaten)
            {
                Snake.Grow(GetNewTail());
                AddFood();
            }

            Draw();
        }
    }

    private bool IsLegalMove(Direction direction, Cell target)
    {
        if (direction.IsOpposite(Snake.Direction))
        {
            return false;
        }

        HasCollided = target.IsForbidden;

        return !HasCollided;
    }

    private Cell GetDestination(Direction direction) => GetDirectionalNeighbor(Snake.Head, direction);

    private Cell GetNewTail() => GetDirectionalNeighbor(Snake.Tail, Snake.Direction.Opposite);

    private Cell GetDirectionalNeighbor(Cell cell, Direction direction)
    {
        var neighbor = new Cell(-1, -1);

        if (direction.IsUp)
        {
            neighbor = TopNeighbor(cell);
        }
        else if (direction.IsRight)
        {
            neighbor = RightNeighbor(cell);
        }
        else if (direction.IsDown)
        {
            neighbor = BottomNeighbor(cell);
        }
        else if (direction.IsLeft)
        {
            neighbor = LeftNeighbor(cell);
        }

        return neighbor;
    }

    private Cell RandomCell()
    {
        bool isEmpty;
        var cell = new Cell(-1, -1);
        do
        {
            cell = _grid[_random.Next(Width), _random.Next(Height)];
            isEmpty = cell.IsEmpty;
        } while (!isEmpty);

        return cell;
    }

    private void InitGrid()
    {
        for (int y = 0; y < Height; y++)
        {
            for (int x = 0; x < Width; x++)
            {
                var cell = new Cell(x, y);

                Add(cell);

                if (IsBorder(cell))
                {
                    cell.SetBorder();
                }
                else
                {
                    cell.SetEmpty();
                }
            }
        }
    }
}