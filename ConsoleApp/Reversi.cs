using static System.Console;

namespace ConsoleApp;
public class Reversi
{  
    public char[,] Execute(char[,] field, char turn)
    {   
        // char ChangeCell (int aliveAroundSum, char cell)
        // {
        //     if (aliveAroundSum == 3) return '*';

        //     if (cell == '*') 
        //     {
        //         if (aliveAroundSum == 2) return '*';
        //     }

        //     return '.';
        // }
        // bool CheckForLine (int startX, int startY, int x, int y, char[,] field)
        // {

        // }
        
        if (field == null || field.GetLength(0) == 0 || field.GetLength(1) == 0) return field;

        var newField = new char [field.GetLength(0), field.GetLength(1)];

        Array.Copy(field, newField, field.Length);
        int height = field.GetLength(0);
        int width = field.GetLength(1);

        char enemy = (turn == 'W') ? 'B' : 'W';

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {   
                    if (field[i,j] != 'W' && field[i,j] != 'B' && field[i,j] != '.')
                    {   
                        WriteLine (field[i,j]);
                        throw new ("Shold be only B or W or .");
                    } 

                    if (field[i,j] == turn)
                    {
                            WriteLine ($"{i}  {j}");
                            for (int y = -1; y <= 1; y++)
                            {
                                for (int x = -1; x <= 1; x++)
                                {
                                    try 
                                    {
                                        if (x != 0 || y != 0)
                                        {
                                            if (field[i+y,j+x] == enemy) 
                                            {
                                                int k = y;
                                                int z = x;
                                                while (field[i+k,j+z] == enemy)
                                                {
                                                    k+=y;
                                                    z+=x;            
                                                };
                                                if (newField [i+k, j+z] == '.') newField [i+k, j+z] = 'O';
                                            };
                                        }
                                    }

                                    catch (IndexOutOfRangeException) 
                                    {   
                                        continue;
                                    }
                                }    
                            }

                    }
                    //newfield[i,j] = ChangeCell(aliveAroundSum, field[i,j]);

                }
            }

        return newField;
    }
}