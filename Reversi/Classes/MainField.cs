
public class MainField
{
    private char[,] Field { get; set; }

    private int a { get; set; }

    private int b { get; set; }

    public Fishka Turn { get; set; }

    public char[,] FindTheMoves(char[,] field, char turn)
    {
        if (CopyArray(field))
        {
            Turn = turn;
            FindTheMoves();
            return this.Field;
        }
        return field;
    }

    private bool CopyArray(char[,] field)
    {
        if (ValidateField(field))
        {
            this.Field = new char[field.GetLength(0), field.GetLength(1)];
            Array.Copy(field, this.Field, field.Length);
            return true;
        }
        return false;
    }

    private bool ValidateField(char[,] field)
    {
        if (field is not null &&
            field.Rank == 2 &&
            field.GetLength(0) == 8 &&
            field.GetLength(1) == 8)
        {
            return true;
        }
        return false;
    }

    private void FindTheMoves()
    {
        for (a = 0; a < 8; ++a)
        {
            for (b = 0; b < 8; ++b)
            {
                if (Field[a, b] == '.')
                {
                    FindByRays();
                }
            }
        }
    }

    private void FindByRays()
    {
        int c = -1;
        int d = -1;
        while (c < 2)
        {
            d = -1;
            while (d < 2)
            {
                if (FindByRay(c, d))
                {
                    Field[a, b] = '0';
                    d = 2;
                    c = 2;
                }
                ++d;
            }
            ++c;
        }
    }

    private bool FindByRay(int e, int f)
    {
        bool isPossibleMove = false;
        int c = 1;
        int d = 1;
        while (c < 8 && a + c * e > -1 && a + c * e < 8 &&
                d < 8 && b + d * f > -1 && b + d * f < 8)
        {
            if (this.Field[a + c * e, b + d * f] == (char)!this.Turn)
            {
                isPossibleMove = true;
            }
            else if (isPossibleMove && this.Field[a + c * e, b + d * f] == (char)this.Turn)
            {
                return true;
            }
            else
            {
                return false;
            }
            ++c;
            ++d;
        }
        return false;
    }

    public MainField()
    {
        Field = new char[0, 0];
        this.a = 0;
        this.b = 0;
        Turn = false;
    }
}