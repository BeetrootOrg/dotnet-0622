
try
{
    System.Console.WriteLine("Введите число ");
    int x = int.Parse(Console.ReadLine());
    System.Console.WriteLine("Введите второе число ");
    int y = int.Parse(Console.ReadLine());

  int sum = 0;
  int operand1 = x;
  int   operand2 = y;

    if (operand1 == operand2)
    {
        sum = operand1;
    }
    else if (y < x)
    {
        operand1 = y;
        operand2 = x;
    }
        for (int i = operand1; i <= operand2; i++)
        {
            sum += i;
        }

    Console.WriteLine("Cумма чисел = {0}", sum);

}
catch (Exception)
{
    Console.WriteLine("Invalid input");
}