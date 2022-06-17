


//Homework :)

string x1;
string y1;
Console.WriteLine("input x");
x1= Console.ReadLine();
Console.WriteLine("input y");
y1 = Console.ReadLine();

int x = Int32.Parse(x1);
int y = Int32.Parse(y1);
int sum = 0;
if (x < y)
{
    while (x <= y)
    {
        sum = sum + x;
        x++;

    }
}
else if (x > y)
{

    while (y <= x)
    {
        sum = sum + y;
        y++;
    }
}
else
{
    sum = x;
}

Console.WriteLine(sum);




















