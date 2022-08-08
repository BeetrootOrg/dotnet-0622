namespace GameOfLife.GameOfLife;

public class GameOfLife
{
    private int[] range { get; set; }

    private char[,] action { get; set; }

    private int[] GenerateRange(int start, int end)
    {
        end = start + 1 < end ? start + 1 : end;
        start = 0 > start - 1 ? 0 : start - 1;

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
        int[] subRangeInRow;
        int[] subRangeInColumn;

        if (CopyArray(cells))
        {
            maxRows = cells.GetLength(0) - 1;
            maxColumns = cells.GetLength(1) - 1;

            for (int a = 0; a < action.GetLength(0); ++a)
            {
                for (int b = 0; b < action.GetLength(1); ++b)
                {
                    num = 0;
                    subRangeInRow = GenerateRange(a, maxRows);
                    foreach (int c in subRangeInRow)
                    {
                        subRangeInColumn = GenerateRange(b, maxColumns);
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
        }
        
        return action;
    }

    private bool CopyArray(char[,] cells)
    {
        if (Validate(cells))
        {
            action = new char[cells.GetLength(0), cells.GetLength(1)];
            Array.Copy(cells, action, cells.Length);
            return true;
        }

        action = new char[0, 0];
        return false;
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