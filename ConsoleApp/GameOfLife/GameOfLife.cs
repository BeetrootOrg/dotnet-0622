public class GameOfLife
{
    private int[] Range(int start, int end)
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
        int maxRows = cells.Rank - 1;
        int maxColumns = 0;
        int num = 0;
        char[,] life = cells;
        if (life.Rank == 2)
        {

            maxRows = life.GetLength(0) - 1;
            for (int a = 0; a < life.GetLength(0); ++a)
            {
                for (int b = 0; b < life.GetLength(1); ++b)
                {
                    num = 0;
                    var positionInRow = Range(Math.Max(0, a - 1), Math.Min(a + 1, maxRows));
                    foreach (int c in positionInRow)
                    {
                        maxColumns = life.GetLength(1) - 1;
                        var positionInColumn = Range(Math.Max(0, b - 1), Math.Min(b + 1, maxColumns));
                        foreach (int d in positionInColumn)
                        {
                            if (life[c, d] == '*')
                            {
                                ++num;
                            }
                        }
                    }
                    if (life[a, b] == '*')
                    {
                        --num;
                    }
                    if (num == 3)
                    {
                        life[a, b] = '*';
                    }
                    else if (num < 2 || num > 3)
                    {
                        life[a, b] = '.';
                    }
                }
            }
        }
        return life;
    }

    char[,] CopyArray(char[,] cells)
    {
        char[,] field = new char[0, 0];
        if (Validate(cells))
        {
            Array.Copy(cells, field, cells.Length);
        }
        return field;
    }

    bool Validate(char[,] cells)
    {
        if (cells is not null &&
        cells.Rank > 0 &&
        cells.GetLength(0) > 0)
        {
            return true;
        }
        return false;
    }
}