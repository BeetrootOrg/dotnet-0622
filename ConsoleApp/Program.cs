char[,] Calculate(char[,] field, char turn)
{
    char[,] result = new char[field.GetLength(0),field.GetLength(1)];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i,j] = field[i,j];       
        }
    }
    
    char notTurn = turn == 'B' ? 'W' : 'B';
    for (int i = 0; i < field.GetLength(0); i++)
    {
        for (int j = 0; j < field.GetLength(1); j++)
        {
            if (field[i,j] == turn) 
            {
                foreach(var point in RayCast(field, notTurn, i, j))
                {
                    result[point.Item1, point.Item2] = 'O';
                }
            }
        }
    }
    
    return result;
}

List<(int,int)> RayCast(char[,] field, char notTurn, int x, int y)
{
    List<(int,int)> result = new List<(int,int)>();
    if ((x,y) != RayCastUp(field, notTurn, x, y)) result.Add(RayCastUp(field, notTurn, x, y));
    if ((x,y) != RayCastUpRight(field, notTurn, x, y)) result.Add(RayCastUpRight(field, notTurn, x, y));
    if ((x,y) != RayCastRight(field, notTurn, x, y)) result.Add(RayCastRight(field, notTurn, x, y));
    if ((x,y) != RayCastDownRight(field, notTurn, x, y)) result.Add(RayCastDownRight(field, notTurn, x, y));
    if ((x,y) != RayCastDown(field, notTurn, x, y)) result.Add(RayCastDown(field, notTurn, x, y));
    if ((x,y) != RayCastDownLeft(field, notTurn, x, y)) result.Add(RayCastDownLeft(field, notTurn, x, y));
    if ((x,y) != RayCastLeft(field, notTurn, x, y)) result.Add(RayCastLeft(field, notTurn, x, y));
    if ((x,y) != RayCastUpLeft(field, notTurn, x, y)) result.Add(RayCastUpLeft(field, notTurn, x, y));
    return result;
}


(int, int) RayCastUp(char[,] field, char notTurn, int x, int y)
{
    char turn = notTurn == 'B' ? 'W' : 'B';
    int s = 0, i = x, j = y;
    while (i > 0)
    {
        i--;
        if (field[i,j] == notTurn) 
        {
            s++;
            continue;
        }
        if (field[i,j] == turn)
        {
            break;
        }
        if (field[i,j] == '.' && s == 0)
        {
            break;
        }
        if (field[i,j] == '.' && s > 0)
        {
            return (i, j);
        }
    }
    return (x,y);    
}

(int, int) RayCastDown(char[,] field, char notTurn, int x, int y)
{
    char turn = notTurn == 'B' ? 'W' : 'B';
    int s = 0, i = x, j = y;
    while (i < field.GetLength(0)-1)
    {
        i++;
        if (field[i,j] == notTurn) 
        {
            s++;
            continue;
        }
        if (field[i,j] == turn)
        {
            break;
        }
        if (field[i,j] == '.' && s == 0)
        {
            break;
        }
        if (field[i,j] == '.' && s > 0)
        {
            return (i, j);
        }
    }
    return (x,y);    
}

(int, int) RayCastLeft(char[,] field, char notTurn, int x, int y)
{
    char turn = notTurn == 'B' ? 'W' : 'B';
    int s = 0, i = x, j = y;
    while (j > 0)
    {
        j--;
        if (field[i,j] == notTurn) 
        {
            s++;
            continue;
        }
        if (field[i,j] == turn)
        {
            break;
        }
        if (field[i,j] == '.' && s == 0)
        {
            break;
        }
        if (field[i,j] == '.' && s > 0)
        {
            return (i, j);
        }
    }
    return (x,y);    
}

(int, int) RayCastRight(char[,] field, char notTurn, int x, int y)
{
    char turn = notTurn == 'B' ? 'W' : 'B';
    int s = 0, i = x, j = y;
    while (j <field.GetLength(1)-1)
    {
        j++;
        if (field[i,j] == notTurn) 
        {
            s++;
            continue;
        }
        if (field[i,j] == turn)
        {
            break;
        }
        if (field[i,j] == '.' && s == 0)
        {
            break;
        }
        if (field[i,j] == '.' && s > 0)
        {
            return (i, j);
        }
    }
    return (x,y);      
}

(int, int) RayCastUpRight(char[,] field, char notTurn, int x, int y)
{
    char turn = notTurn == 'B' ? 'W' : 'B';
    int s = 0, i = x, j = y;
    while (i > 0 && j <field.GetLength(1)-1)
    {
        i--;
        j++;
        if (field[i,j] == notTurn) 
        {
            s++;
            continue;
        }
        if (field[i,j] == turn)
        {
            break;
        }
        if (field[i,j] == '.' && s == 0)
        {
            break;
        }
        if (field[i,j] == '.' && s > 0)
        {
            return (i, j);
        }
    }
    return (x,y);     
}

(int, int) RayCastDownRight(char[,] field, char notTurn, int x, int y)
{
    char turn = notTurn == 'B' ? 'W' : 'B';
    int s = 0, i = x, j = y;
    while (i < field.GetLength(0)-1 && j <field.GetLength(1)-1)
    {
        i++;
        j++;
        if (field[i,j] == notTurn) 
        {
            s++;
            continue;
        }
        if (field[i,j] == turn)
        {
            break;
        }
        if (field[i,j] == '.' && s == 0)
        {
            break;
        }
        if (field[i,j] == '.' && s > 0)
        {
            return (i, j);
        }
    }
    return (x,y);    
}

(int, int) RayCastDownLeft(char[,] field, char notTurn, int x, int y)
{
    char turn = notTurn == 'B' ? 'W' : 'B';
    int s = 0, i = x, j = y;
    while (j > 0 && i < field.GetLength(0)-1)
    {
        i++;
        j--;
        if (field[i,j] == notTurn) 
        {
            s++;
            continue;
        }
        if (field[i,j] == turn)
        {
            break;
        }
        if (field[i,j] == '.' && s == 0)
        {
            break;
        }
        if (field[i,j] == '.' && s > 0)
        {
            return (i, j);
        }
    }
    return (x,y);      
}

(int, int) RayCastUpLeft(char[,] field, char notTurn, int x, int y)
{
    char turn = notTurn == 'B' ? 'W' : 'B';
    int s = 0, i = x, j = y;
    while (i > 0 && j > 0)
    {
        i--;
        j--;
        if (field[i,j] == notTurn) 
        {
            s++;
            continue;
        }
        if (field[i,j] == turn)
        {
            break;
        }
        if (field[i,j] == '.' && s == 0)
        {
            break;
        }
        if (field[i,j] == '.' && s > 0)
        {
            return (i, j);
        }
    }
    return (x,y);     
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
WriteArray(Calculate(input, 'B'));