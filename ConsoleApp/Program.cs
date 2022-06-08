
Console.WriteLine("Перша частина ДЗ");

int x = 5;
int y = 5;

int sum = 0;

if (x!=y)
{
    if (y>x)
    {
    for (int i = x; i <= y; i++)
        {
        sum += i;
        }
    Console.WriteLine($"Сума всіх чисел між х та у: {sum}");
    }
    else
    {
        for (int i = y; i <= x; i++)
        {
            sum += i;
        }
        Console.WriteLine($"Сума всіх чисел між х та у: {sum}");
    }
}
else
Console.WriteLine($"Сума всіх чисел між х та у: {x}");

//Друга частина дз Варіант 1

int firstvalue = 0;
int secondvalue = 0;


try
{
    Console.WriteLine("Введіть число X");
    firstvalue = int.Parse(Console.ReadLine());
    Console.WriteLine("Введіть число Y");
    secondvalue = int.Parse(Console.ReadLine());
    Console.WriteLine($"Ви ввели числа {firstvalue} {secondvalue}");       //Цього в умові не було, але це було б логічно, вивести на екран результат
}
catch (Exception)
{
    Console.WriteLine("Invalid input");
} 



//Друга частина дз Варіант 2

 firstvalue = 0;
 secondvalue = 0;
Console.WriteLine("Введіть число X");
if (int.TryParse(Console.ReadLine(), out firstvalue))
{
    Console.WriteLine("Введіть число Y");
    if (int.TryParse(Console.ReadLine(), out secondvalue))
    {
        Console.WriteLine($"Ви ввели числа {firstvalue} {secondvalue}");    //Цього в умові не було, але це було б логічно, вивести на екран результат
    }
    else
    Console.WriteLine("Invalid input");
}
else
Console.WriteLine("Invalid input");