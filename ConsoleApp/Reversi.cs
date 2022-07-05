using static System.Console;

namespace ConsoleApp;
public class Reversi
{  
    public char[,] Execute(char[,] field, char turn)
    {   
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
                    throw new ("Shold be only B or W or .");
                } 

                if (field[i,j] == turn)
                {
                    for (int y = -1; y <= 1; y++)
                    {
                        for (int x = -1; x <= 1; x++)
                        {
                            try 
                            {
                                if (x != 0 || y != 0)
                                {
                                    int k = y;
                                    int z = x;
                                    bool toPutMark = false; 

                                    while (field[i + k, j + z] == enemy)
                                    {
                                        k+=y;
                                        z+=x;
                                        toPutMark = true;            
                                    };

                                    if (toPutMark && newField [i + k, j + z] == '.') 
                                        newField [i + k, j + z] = 'O';
                                }
                            }

                            catch (IndexOutOfRangeException) 
                            {   
                                continue;
                            }
                        }    
                    }

                }

            }
        }

        return newField;
    }
}