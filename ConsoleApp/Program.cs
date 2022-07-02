public class GameOfLife
{
    public char[,] Execute(char[,] cells)
    {
        char[,] result = new char[cells.GetLength(0), cells.GetLength(1)];
        char[,] copy = new char[cells.GetLength(0) + 2, cells.GetLength(1) + 2];
        
        for (int i = 0; i < cells.GetLength(0); i++)
            for (int j = 0; j < cells.GetLength(1); j++)
            {
                result[i,j] = '.';
                copy[i+1, j+1] = cells[i,j];
            }

        for (int i = 0; i < cells.GetLength(0); i++)
            for (int j = 0; j < cells.GetLength(1); j++)
            {
                int count = CountOfLive(copy, i+1, j+1);
                if ((count == 2 || count == 3) && copy[i+1, j+1] == '*') result[i,j] = '*';
                if (count == 3 && copy[i+1, j+1] == '.') result[i,j] = '*';
            }               

        return result;
    }


    public int CountOfLive(char[,] a, int i, int j)
    {
        int live = 0;
        if (a[i - 1, j - 1] == '*') live++;
        if (a[i - 1, j] == '*') live++;
        if (a[i - 1, j + 1] == '*') live++;
        if (a[i, j - 1] == '*') live++;
        if (a[i, j + 1] == '*') live++;
        if (a[i + 1, j - 1] == '*') live++;
        if (a[i + 1, j] == '*') live++;
        if (a[i + 1, j + 1] == '*') live++;
        return live;
    }

    
    private static void Main(string[] args)
    {
       
    }
}