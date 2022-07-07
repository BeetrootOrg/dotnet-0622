char[,] Calculate(char[,] field, char turn)
{
    char[,] temp = new char[field.GetLength(0)+2,field.GetLength(1)+2];
    for (int i = 0; i < field.GetLength(0); i++)
    {
        for (int j = 0; j < field.GetLength(1); j++)
        {
            temp[i+1,j+1] = field[i,j];       
        }
    }
    
    char notTurn = turn == 'B' ? 'W' : 'B';
    for (int i = 0; i < field.GetLength(0); i++)
    {
        for (int j = 0; j < field.GetLength(1); j++)
        {
            if (field[i,j] == '.') 
            {
                if (Near(temp, notTurn, i+1, j+1)) temp[i+1,j+1] = '0';
            }
        }
    }
    return temp;
}

bool Near(char[,] field, char notTurn, int i, int j)
{
    if (field[i-1,j-1] == notTurn ||
        field[i-1,j] == notTurn ||
        field[i-1,j+1] == notTurn ||
        field[i,j-1] == notTurn ||
        field[i,j+1] == notTurn ||
        field[i+1,j-1] == notTurn ||
        field[i+1,j] == notTurn ||
        field[i+1,j+1] == notTurn) return true;
    else return false;
}

void WriteArray(char[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i,j]);
        }
        Console.WriteLine();
    }
}

char[,] input = new char[8,8] { {'.','.','.','.','.','.','.','.'},
                                {'.','.','.','.','.','.','.','.'},
                                {'.','.','.','.','.','.','.','.'},
                                {'.','.','.','B','W','.','.','.'},
                                {'.','.','.','W','B','.','.','.'},
                                {'.','.','.','.','.','.','.','.'},
                                {'.','.','.','.','.','.','.','.'},
                                {'.','.','.','.','.','.','.','.'} };

WriteArray(input);
Console.WriteLine();
WriteArray(Calculate(input, 'W'));