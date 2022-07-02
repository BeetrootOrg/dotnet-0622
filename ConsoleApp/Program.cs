
public class GameOfLife
{
    public char[,] Execute(char[,] cells)
    {
        int stroka1 = 0,stroka2 = 0,stroka3 = 0;

        Boolean booltemp;
        
        for (int x = 0; x < cells.GetLength(0); x++)
        {
            for (int y = 0; y < cells.GetLength(1); y++)
            {
                if (cells[x, y].Equals('*'))
                {
                    try
                    {
                        if (cells[x - 1, y - 1].Equals('*'))
                        {
                            stroka1++;
                        }
                    }
                    catch (Exception)
                    {
                    }
                    try
                    {
                        if (cells[x - 1, y].Equals('*'))
                        {
                            stroka1++;
                        }
                    }
                    catch (Exception)
                    {
                    }
                    try
                    {
                        if (cells[x - 1, y + 1].Equals('*'))
                        {
                            stroka1++;
                        }
                    }
                    catch (Exception)
                    {
                    }
                    try
                    {
                        if (cells[x, y - 1].Equals('*'))
                        {
                            stroka2++;
                        }
                    }
                    catch (Exception)
                    {
                    }
                    try
                    {
                        if (cells[x, y + 1].Equals('*'))
                        {
                            stroka2++;
                        }
                    }
                    catch (Exception)
                    {
                    }
                    try
                    {
                        if (cells[x + 1, y - 1].Equals('*'))
                        {
                            stroka3++;
                        }
                    }
                    catch (Exception)
                    {
                    }
                    try
                    {
                        if (cells[x + 1, y].Equals('*'))
                        {
                            stroka3++;
                        }
                    }
                    catch (Exception)
                    {
                    }
                    try
                    {
                        if (cells[x + 1, y + 1].Equals('*'))
                        {
                            stroka1++;
                        }
                    }
                    catch (Exception)
                    {
                    }
                }

                if (stroka1 + stroka2 + stroka3 > 3 || stroka1 + stroka2 + stroka3 < 2)
                {
                    cells[x, y] = '.';
                }
                else if ()
            }
        }
        return cells;
    }
}