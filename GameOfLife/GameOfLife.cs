namespace GameOfLife;
public class GameOfLife
{
    private const char LiveCell = '*';
    private const char DeadCell = '.';

    public char[,] Execute(char[,] cells)
    {
        // here goes the implementation
        var dim1 = cells.GetLength(0);
        var dim2 = cells.GetLength(1);
        var copy = new char[dim1, dim2];

        for (int i = 0; i < dim1; ++i)
        {
            for (int j = 0; j < dim2; ++j)
            {
                var neigbors = CountNeighbors(cells, i, j);
                if (cells[i, j] == LiveCell && (neigbors == 2 || neigbors == 3))
                {
                    copy[i, j] = LiveCell;
                }
                else if (cells[i, j] == DeadCell && neigbors == 3)
                {
                    copy[i, j] = LiveCell;
                }
                else
                {
                    copy[i, j] = DeadCell;
                }
            }
        }

        return copy;
    }

    private static int CountNeighbors(char[,] cells, int x, int y)
    {
        var count = 0;
        int dim1 = cells.GetLength(0);
        int dim2 = cells.GetLength(1);

        for (int i = x - 1; i <= x + 1; ++i)
        {
            if (i < 0 || i >= dim1)
            {
                continue;
            }

            for (int j = y - 1; j <= y + 1; ++j)
            {
                if (j < 0 || j >= dim2)
                {
                    continue;
                }

                if (i == x && j == y)
                {
                    continue;
                }

                if (cells[i, j] == LiveCell)
                {
                    ++count;
                }
            }
        }

        return count;
    }
}
