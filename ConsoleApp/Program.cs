public class GameOfLife
{
    public char[,] Execute(char[,] cells)
    {
        char[,] copy = new char[cells.GetLength(0) + 2, cells.GetLength(1) + 2];
        for (int i = 0; i < copy.GetLength(0); i++)
        {
            for (int j = 0; j < copy.GetLength(1); j++)
            {
                if (i == 0 || j == 0 || i == copy.GetLength(0) - 1 || j == copy.GetLength(1) - 1) copy[i, j] = '.';
                else copy[i, j] = cells[i - 1, j - 1];
            }
        }
        for (int i = 0; i < copy.GetLength(0); i++)
        {
            for (int j = 0; j < copy.GetLength(1); j++)
            {
                int count = 0;
                string elements = "";
                if (i == 0 || j == 0 || i == copy.GetLength(0) - 1 || j == copy.GetLength(1) - 1) continue;
                else
                {
                    elements += copy[i - 1, j - 1] == '*' ? '*' : null;
                    elements += copy[i - 1, j] == '*' ? '*' : null;
                    elements += copy[i - 1, j + 1] == '*' ? '*' : null;
                    elements += copy[i, j - 1] == '*' ? '*' : null;
                    elements += copy[i, j + 1] == '*' ? '*' : null;
                    elements += copy[i + 1, j - 1] == '*' ? '*' : null;
                    elements += copy[i + 1, j] == '*' ? '*' : null;
                    elements += copy[i + 1, j + 1] == '*' ? '*' : null;
                    count = elements.Length >= 2 && elements.Length < 4 ? 1 : 0;
                    switch (copy[i, j])
                    {
                        case '*':
                            {
                                switch (count)
                                {
                                    case 0:
                                        {
                                            cells[i - 1, j - 1] = '.';
                                            break;
                                        }
                                    case 1:
                                        {
                                            cells[i - 1, j - 1] = '*';
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
                                            cells[i - 1, j - 1] = '.';
                                            break;
                                        }
                                    case true:
                                        {
                                            cells[i - 1, j - 1] = '*';
                                            break;
                                        }
                                }
                                break;
                            }
                    }
                }
            }
        }
        return cells;
    }
}