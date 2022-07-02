public class GameOfLife
{
    public  static char[,] Execute(char[,] cells)
    {
        char[,] copy = new char[cells.GetLength(0), cells.GetLength(1)];
        Array.Copy(cells,copy,cells.Length);
        for (int i = 0; i < cells.GetLength(0); i++)
        {
            for (int j = 0; j < cells.GetLength(1); j++)
            {
                int count = 0;
                string elements = "";
                if (i == 0 || j == 0 || i == cells.GetLength(0) - 1 || j == cells.GetLength(1) - 1) continue;
                else
                {
                    elements += cells[i - 1, j - 1] == '*' ? '*' : null;
                    elements += cells[i - 1, j] == '*' ? '*' : null;
                    elements += cells[i - 1, j + 1] == '*' ? '*' : null;
                    elements += cells[i, j - 1] == '*' ? '*' : null;
                    elements += cells[i, j + 1] == '*' ? '*' : null;
                    elements += cells[i + 1, j - 1] == '*' ? '*' : null;
                    elements += cells[i + 1, j] == '*' ? '*' : null;
                    elements += cells[i + 1, j + 1] == '*' ? '*' : null;
                    count = elements.Length;
                    count = elements.Length >= 2 && elements.Length < 4 ? 1 : 0;
                    switch (cells[i,j])
                    {
                        case '*':
                            {
                                switch (count)
                                {
                                    case 0:
                                        {
                                            copy[i, j] = '.';
                                            break;
                                        }
                                    case 1:
                                        {
                                            copy[i, j] = '*';
                                            break;
                                        }
                                }
                                break;
                            }
                        case '.':
                            {
                                switch (elements.Length == 3)
                                {
                                    case false:
                                        {
                                            copy[i, j] = '.';
                                            break;
                                        }
                                    case true:
                                        {
                                            copy[i, j] = '*';
                                            break;
                                        }
                                }
                                break;
                            }
                    }
                    
                }
            }
        }
        return copy;
    }
}