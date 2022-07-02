using static System.Console;
public class GameOfLife
{
    public char[,] Execute(char[,] cells)
    {
        int columns = cells.GetLength(0);
        int rows = cells.GetLength(1);

        for (int i = 0; i < columns; ++i)
        {
            for (int j = 0; j < rows; ++j)
            {
                var position = (i, j);
                ExtintionOrDevelop(cells, position);
            }
        }

        return cells;
    }

    public bool Alive(char[,] cells, (int, int) position) => cells[position.Item1, position.Item2] == '*';

    public char[,] ExtintionOrDevelop(char[,] cells, (int, int) position)
    {
        int neeighborsCount = GetNeighbors(cells, position.Item1, position.Item2);
        if (neeighborsCount < 2)
        {
            if (Alive(cells, position))
            {
                cells[position.Item1, position.Item2] = '.';
                return cells;
            }
        }

        if (neeighborsCount == 3 || neeighborsCount == 2)
        {
            if (Alive(cells, position))
            {
                return cells;
            }
            if (neeighborsCount == 3)
            {
                cells[position.Item1, position.Item2] = '*';
                return cells;
            }
        }
        if (neeighborsCount > 3)
        {
            if (Alive(cells, position))
            {
                cells[position.Item1, position.Item2] = '.';
                return cells;
            }
        }

        return cells;
    }

    public int NeighborCount(char[,] cells, (int, int) position, int posXStart, int posXEnd, int posYStart,  int PosYEnd)
    {
        int aliveNeighborCount = 0;

        int ourCell = cells[position.Item1, position.Item2];

        for (int i = posXStart; i <= posXEnd; ++i)
        {
            for (int j = posYStart; i <= PosYEnd; ++j)
            {
                if (cells[i, j] == ourCell) continue;
                if (cells[i, j] == '*') aliveNeighborCount++;
            }
        }

        return aliveNeighborCount;
    }

    public int GetNeighbors(char[,] cells, int posX, int posY)
    {
        var position = (posX, posY);

        int columns = cells.GetLength(0);
        int rows = cells.GetLength(1);

        //left up corner
        if (posX - 1 < 0 && posY - 1 < 0)
        {
            return NeighborCount(cells, position, posX, posX + 1, posY, posY + 1);
        }

        //left down corner
        if (posX - 1 < 0 && posY + 1 > rows)
        {
            return NeighborCount(cells, position, posX, posX + 1, posY - 1, posY);
        }

        //right up corner
        if (posX + 1 > columns && posY - 1 < 0)
        {
            return NeighborCount(cells, position, posX - 1, posX, posY, posY + 1);
        }

        //right  down corner
        if (posX + 1 > columns && posY + 1 > rows)
        {
            return NeighborCount(cells, position, posX - 1, posX, posY - 1, posY);
        }

        //left column
        if (posX - 1 < 0)
        {
            return NeighborCount(cells, position, posX, posX + 1, posY - 1, posY + 1);

        }

        //right column
        if (posX + 1 > columns)
        {
            return NeighborCount(cells, position, posX - 1, posX + 1, posY - 1, posY + 1);
        }

        //up row
        if (posY - 1 < 0)
        {
            return NeighborCount(cells, position, posX - 1, posX + 1, posY, posY + 1);
        }

        //down row
        if (posY + 1 > rows)
        {
            return NeighborCount(cells, position, posX - 1, posX + 1, posY - 1, posY);
        }
        //inside
        return NeighborCount(cells, position, posX - 1, posX + 1, posY - 1, posY + 1);

    }

}



