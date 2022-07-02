using static System.Console;

namespace ConsoleApp;
public class GameOfLife
{  
    public static char[,] Execute(char[,] cells)
    {   
        char ChangeCell (int aliveAroundSum, char cell)
        {
            if (aliveAroundSum == 3) return '*';

            if (cell == '*') 
            {
                if (aliveAroundSum == 2) return '*';
            }

            return '.';
        }
        
        if (cells == null || cells.GetLength(0) == 0 || cells.GetLength(1) == 0) return cells;

        var newCells = new char [cells.GetLength(0), cells.GetLength(1)];

        Array.Copy(cells, newCells, cells.Length);
        int height = cells.GetLength(0);
        int width = cells.GetLength(1);

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {   
                    if (cells[i,j] != '*' && cells[i,j] != '.')
                    {   
                        WriteLine (cells[i,j]);
                        throw new ("Shold be only * or .");
                    } 

                    int aliveAroundSum = 0;
                    
                            for (int y = -1; y <= 1; y++)
                            {
                                for (int x = -1; x <= 1; x++)
                                {
                                    try 
                                    {
                                        if (x != 0 || y != 0)
                                        {
                                        if (cells[i+y,j+x] == '*') aliveAroundSum++;
                                        }
                                    }

                                    catch (IndexOutOfRangeException) 
                                    {   
                                        continue;
                                    }
                                }    
                            }

                    newCells[i,j] = ChangeCell(aliveAroundSum, cells[i,j]);
                    
                }
            }

        return newCells;
    }
}