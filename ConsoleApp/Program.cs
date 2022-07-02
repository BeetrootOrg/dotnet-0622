internal class Program
{
  public static int[,] GetGeneration(int[,] cells, int generation)
    {
        int i;
        int[,] copy = new int[cells.GetLength(0), cells.GetLength(1)];
        int[,] extraCells = new int[cells.GetLength(0) + 2, cells.GetLength(1) + 2];

        for (int j = 0; j < cells.GetLength(0); j++)
        {
            for (int k = 0; k < cells.GetLength(1); k++)
            {
                extraCells[j + 1, k + 1] = cells[j, k];
            }
        }

        int[,] temp = new int[cells.GetLength(0) + 2, cells.GetLength(1) + 2];
        for (i = 0; i < generation; i++)
        {
            for (int j = 1; j < extraCells.GetLength(0) - 1; j++)
            {
                for (int k = 1; k < extraCells.GetLength(1) - 1; k++)
                {
                    int count = CountOfLive(extraCells, j, k);
                    if (extraCells[j, k] == 1)
                    {
                        if (count == 2 || count == 3) temp[j, k] = 1;
                    }
                    else
                    {
                        if (count == 3) temp[j, k] = 1;
                    }
                }
            }

            for (int j = 1; j < extraCells.GetLength(0) - 1; j++)
            {
                for (int k = 1; k < extraCells.GetLength(1) - 1; k++)
                {
                    extraCells[j, k] = temp[j, k];
                    temp[j, k] = 0;
                }
            }
        }

        for (int j = 0; j < cells.GetLength(0); j++)
        {
            for (int k = 0; k < cells.GetLength(1); k++)
            {
                copy[j, k] = extraCells[j + 1, k + 1];
            }
        }

        return copy;
    }


    static int CountOfLive(int[,] a, int i, int j)
    {
        int live = 0;
        if (a[i - 1, j - 1] == 1) live++;
        if (a[i - 1, j] == 1) live++;
        if (a[i - 1, j + 1] == 1) live++;
        if (a[i, j - 1] == 1) live++;
        if (a[i, j + 1] == 1) live++;
        if (a[i + 1, j - 1] == 1) live++;
        if (a[i + 1, j] == 1) live++;
        if (a[i + 1, j + 1] == 1) live++;
        return live;

    }
    private static void Main(string[] args)
    {
        
    }
}