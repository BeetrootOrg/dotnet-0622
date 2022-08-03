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
    public char[,] Execute(char[,] cells)
    {
        int maxRows = 0;
        int maxColumns = 0;
        int num = 0;
        int[] rangeInRow;
        int[] rangeInColumn;
        char[,] action = CopyArray(cells);
        maxRows = action.GetLength(0) - 1;
        for (int a = 0; a < action.GetLength(0); ++a)
        {
            for (int b = 0; b < action.GetLength(1); ++b)
            {
                num = 0;
                rangeInRow = GenerateRange(Math.Max(0, a - 1), Math.Min(a + 1, maxRows));
                foreach (int c in rangeInRow)
                {
                    maxColumns = action.GetLength(1) - 1;
                    rangeInColumn = GenerateRange(Math.Max(0, b - 1), Math.Min(b + 1, maxColumns));
                    foreach (int d in rangeInColumn)
                    {
                        if (action[c, d] == '*')
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