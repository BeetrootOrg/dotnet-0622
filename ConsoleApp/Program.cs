namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[,] life = new char[,] {
                {'.','.','*','.','.','*','.','*','.'},
                {'*','.','*','.','*','.','*','.','*'},
                {'.','.','*','.','.','*','.','*','.'},
                {'.','*','*','.','.','*','.','*','.'},
                {'.','*','*','.','.','*','.','*','.'},
                {'.','*','*','.','.','*','.','*','.'},
                {'.','.','*','.','.','*','.','*','.'},
                {'.','.','*','.','.','*','.','*','.'},
                };

            GameOfLife game = new GameOfLife();

            char[,] result = game.Execute(life);

            for (int x = 0; x < result.GetLength(0); x++)
            {
                for (int y = 0; y < result.GetLength(1); y++)
                {
                    Console.Write(result[x, y]);
                }
                Console.WriteLine();
            }
        }
    }


    public class GameOfLife
    {
        public char[,] Execute(char[,] cells)
        {
            char[,] newcount = new char[cells.GetLength(0), cells.GetLength(1)];
            

            for (int x = 0; x < cells.GetLength(0); x++)
            {
                for (int y = 0; y < cells.GetLength(1); y++)
                {
                    int stroka1 = 0, stroka2 = 0, stroka3 = 0;
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

                    if (cells[x, y].Equals('*') && (stroka1 + stroka2 + stroka3 > 3 || stroka1 + stroka2 + stroka3 < 2))
                    {
                            newcount[x, y] = '.';
                    }

                    if (cells[x, y].Equals('.'))
                    {
                        if (stroka1 + stroka2 + stroka3 == 3)
                        {
                            newcount[x, y] = '*';
                        }
                        else
                            newcount[x, y] = '.';
                    }
                    if (cells[x, y].Equals('*') && (stroka1 + stroka2 + stroka3 == 3 || stroka1 + stroka2 + stroka3 == 2))

                        newcount[x,y] = '*';

                }
            }
            return newcount;
        }
    }
}