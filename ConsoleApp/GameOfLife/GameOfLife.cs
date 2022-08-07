namespace ConsoleApp.GameOfLife;

public class GameOfLife
{
    private int[] GenerateRange(int start, int end)
    {
        int[] range = new int[] { 0 };
        if (start < end)
        {
            range = new int[end - start + 1];
            for (int a = 0; a < range.Length; ++a)
            {
                range[a] = start + a;
            }
        }
        return range;
    }

    private int[] GenerateSubRange(int index, int limit)
    {
        return GenerateRange((0 > index - 1 ? 0 : index - 1), (index + 1 < limit ? index + 1 : limit));
    }

    public char[,] Execute(char[,] cells)
    {
        int maxRows = 0;
        int maxColumns = 0;
        int num = 0;
        int[] subRangeInRow;
        int[] subRangeInColumn;
        char[,] action = CopyArray(cells);
        maxRows = cells.GetLength(0) - 1;
        maxColumns = cells.GetLength(1) - 1;
        for (int a = 0; a < cells.GetLength(0); ++a)
        {
            for (int b = 0; b < cells.GetLength(1); ++b)
            {
                num = 0;
                subRangeInRow = GenerateSubRange(a, maxRows);
                foreach (int c in subRangeInRow)
                {
                    subRangeInColumn = GenerateSubRange(b, maxColumns);
                    foreach (int d in subRangeInColumn)
                    {
                        if (cells[c, d] == '*')
                        {
                            ++num;
                        }
                    }
                }
                if (action[a, b] == '*')
                {
                    --num;
                }
                if (num == 3)
                {
                    action[a, b] = '*';
                }
                else if (num < 2 || num > 3)
                {
                    action[a, b] = '.';
                }
            }
        }
        return action;
    }

    char[,] CopyArray(char[,] cells)
    {
        char[,] copyCells = new char[0, 0];
        if (Validate(cells))
        {
            copyCells = new char[cells.GetLength(0), cells.GetLength(1)];
            Array.Copy(cells, copyCells, cells.Length);
        }
        return copyCells;
    }

    bool Validate(char[,] cells)
    {
        if (cells is not null &&
            cells.Rank == 2 &&
            cells.GetLength(0) > 0 &&
            cells.GetLength(1) > 0)
        {
            return true;
        }
        return false;
    }
}