using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace SnakeGame;
public class Board
{
    public static DirectionMap DirectionMap { get; } = new DirectionMap();

    private readonly string instructions = "How to Play: Avoid hitting walls or yourself. Grow by eating food (%). Highest length wins.";
    private readonly string commandBase = "Commands: {0}, Esc: Quit\n";
    private readonly string lengthBase = "Length: {0}\n";

    private Cell[,] grid;
    private Random random = new Random();
    private int leftEdgeX => 0;
    private int rightEdgeX => Width - 1;
    private int topEdgeY => 0;
    private int bottomEdgeY => Height - 1;

    public Snake Snake { get; private set; }
    public int Height { get; private set; }
    public int Width { get; private set; }
    public Cell Current => Snake.Head;
    public Cell Center => get(Width / 2, Height / 2);
    public Cell Food { get; private set; }
    public bool HasCollided { get; private set; }

    public Board(int width = 90, int height = 25)
    {
        Width = width;
        Height = height;
        grid = new Cell[Width, Height];
        initGrid();
    }

    //continue in the same direction
    public void DoTurn()
    {
        doTurn(Snake.Direction, getDestination(Snake.Direction));
    }

    public void DoTurn(Direction direction)
    {
        doTurn(direction, getDestination(direction));
    }

    public void Draw()
    {
        Console.SetCursorPosition(0, 0);
        Console.WriteLine(ToString());
    }

    public void Add(Snake snake) => Snake = snake;
    public void AddFood() => randomCell().SetFood();

    public Cell TopNeighbor(Cell cell) => grid[cell.X, cell.Y - 1];
    public Cell RightNeighbor(Cell cell) => grid[cell.X + 1, cell.Y];
    public Cell BottomNeighbor(Cell cell) => grid[cell.X, cell.Y + 1];
    public Cell LeftNeighbor(Cell cell) => grid[cell.X - 1, cell.Y];

    public override string ToString()
    {
        var sb = new StringBuilder();
        //y is in outer loop, so we draw by rows
        for (int y = 0; y < Height; y++)
        {
            for (int x = 0; x < Width; x++)
            {
                sb.Append(grid[x, y].Value);
            }
            sb.Append("\n"); //terminate row
        }
        sb.AppendFormat(lengthBase, Snake.Length);
        sb.AppendLine(instructions);
        sb.AppendFormat(commandBase, DirectionMap.ToString());
        return sb.ToString();
    }

    private Cell get(int x, int y) => grid[x, y];

    private void add(Cell cell) => grid[cell.X, cell.Y] = cell;

    private bool isBorder(Cell cell) => cell.X == leftEdgeX || cell.X >= rightEdgeX
                                     || cell.Y == topEdgeY || cell.Y >= bottomEdgeY;

    private void doTurn(Direction direction, Cell target)
    {
        if (isLegalMove(direction, target))
        {
            Snake.Move(direction, target);

            if (Snake.HasEaten)
            {
                Snake.Grow(getNewTail());
                AddFood();
            }

            Draw();
        }
    }

    private bool isLegalMove(Direction direction, Cell target)
    {
        if (direction.IsOpposite(Snake.Direction))
        {
            return false;
        }

        HasCollided = target.IsForbidden;

        return !HasCollided;
    }

    private Cell getDestination(Direction direction) => getDirectionalNeighbor(Snake.Head, direction);

    private Cell getNewTail() => getDirectionalNeighbor(Snake.Tail, Snake.Direction.Opposite);

    private Cell getDirectionalNeighbor(Cell cell, Direction direction)
    {
        var neighbor = new Cell(-1, -1); //initialize to dummy cell

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

    private Cell randomCell()
    {
        bool isEmpty;
        var cell = new Cell(-1, -1); //initialize to dummy cell
        do
        {
            cell = grid[random.Next(Width), random.Next(Height)];
            isEmpty = cell.IsEmpty;
        } while (!isEmpty);

        return cell;
    }

    private void initGrid()
    {
        for (int y = 0; y < Height; y++)
        {
            for (int x = 0; x < Width; x++)
            {
                var cell = new Cell(x, y);

                add(cell);

                if (isBorder(cell))
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