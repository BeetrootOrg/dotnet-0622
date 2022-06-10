 System.Console.WriteLine("Введите число ");
                int x = int.Parse(Console.ReadLine());
                System.Console.WriteLine("Введите второе число ");
                int y = int.Parse(Console.ReadLine());

                   int sum = 0;
                   int operand1 = x;
                   int operand2 = y;

                while (true)
                {
                    if (operand1 == operand2)

                    {
                        sum = operand1;
                        Console.WriteLine("Числа равны {0}", sum);
                        break;
                    }

                    if (y < x)
                    {
                        operand1 = y;
                        operand2 = x;
                    }

                    for (int i = operand1; i <= operand2; i++)
                    {
                        sum += i;
                    }

                    Console.WriteLine("Cумма чисел = {0}", sum);
                    break;
                }

            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input");
            }
