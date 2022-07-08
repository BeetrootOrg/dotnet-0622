char[,] Reversi(char[,]field, char turn)
{
    char w = turn == 'B' ? 'W' : 'B';

    for (int i = 0; i < field.GetLength(0); i++)
    {
        for (int j = 0; j < field.GetLength(1); j++)
        {
            if(field[i, j] == turn)
            {
                //up
                int count = 0;
                for (int e = i - 1; e + 1 >= 0; e--)
                {
                    if (field[e, j] == w)
                    {
                        count++;
                        continue;
                    }
                    if (field[e, j] == turn || field[e, j] == '0' || (field[e, j] == '.' && e == i - 1)) break;
                    else if (field[e, j] == '.' && count > 0)
                    {
                        field[e, j] = '0';
                        break;
                    }
                }

                //right
                count = 0;
                for (int e = j + 1; e <= field.GetLength(1) - 1; e++)
                {
                    if (field[i, e] == w)
                    {
                        count++;
                        continue;
                    }
                    if (field[i, e] == turn || field[i, e] == '0' || (field[i, e] == '.' && e == j + 1)) break;
                    else if (field[i, e] == '.' && count > 0)
                    {
                        field[i, e] = '0';
                        break;
                    }
                }

                //down
                count = 0;
                for (int e = i + 1; e <= field.GetLength(0) - 1; e++)
                {
                    if (field[e, j] == w)
                    {
                        count++;
                        continue;
                    }
                    if (field[e, j] == turn || field[e, j] == '0' || (field[e, j] == '.' && e == i + 1)) break;
                    else if (field[e, j] == '.' && count > 0)
                    {
                        field[e, j] = '0';
                        break;
                    }
                }

                //left
                count = 0;
                for (int e = j - 1; e + 1 >= 0; e--)
                {
                    if (field[i, e] == w)
                    {
                        count++;
                        continue;
                    }
                    if (field[i, e] == turn || field[i, e] == '0' || (field[i, e] == '.' && e == j - 1)) break;
                    else if (field[i, e] == '.' && count > 0)
                    {
                        field[i, e] = '0';
                        break;
                    }
                }


                //diag up right
                count = 0;
                for (int t = i - 1, e = j + 1 ; e <= field.GetLength(1) - 1 && t + 1 >= 0; e++,t--)
                {
                    if (field[t, e] == w)
                    {
                        count++;
                        continue;
                    }
                    if (field[t, e] == turn || field[t, e] == '0' || (field[t, e] == '.' && t == i - 1  && e == j + 1)) break;
                    else if (field[t, e] == '.' && count > 0)
                    {
                        field[t, e] = '0';
                        break;
                    }
                }

                //diag down right
                count = 0;
                for (int t = i + 1, e = j + 1; e <= field.GetLength(1) - 1 && t <= field.GetLength(0) - 1; e++, t++)
                {
                    if (field[t, e] == w)
                    {
                        count++;
                        continue;
                    }
                    if (field[t, e] == turn || field[t, e] == '0' || (field[t, e] == '.' && t == i + 1 && e == j + 1)) break;
                    else if (field[t, e] == '.' && count > 0)
                    {
                        field[t, e] = '0';
                        break;
                    }
                }

                //diag up left
                count = 0;
                for (int t = i - 1, e = j - 1; e + 1 >= 0 && t + 1 >= 0; e--, t--)
                {
                    if (field[t, e] == w)
                    {
                        count++;
                        continue;
                    }
                    if (field[t, e] == turn || field[t, e] == '0' || (field[t, e] == '.' && t == i - 1 && e == j - 1)) break;
                    else if (field[t, e] == '.' && count > 0)
                    {
                        field[t, e] = '0';
                        break;
                    }
                }

                //diag down left
                count = 0;
                for (int t = i + 1, e = j - 1; e + 1 >= 0 && t <= field.GetLength(0) - 1; e--, t++)
                {
                    if (field[t, e] == w)
                    {
                        count++;
                        continue;
                    }
                    if (field[t, e] == turn || field[t, e] == '0' || (field[t, e] == '.' && t == i + 1 && e == j - 1)) break;
                    else if (field[t, e] == '.' && count > 0)
                    {
                        field[t, e] = '0';
                        break;
                    }
                }
            }
        }
    }
    return field;
}