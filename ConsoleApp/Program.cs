Console.WriteLine("How long to count the Fibonacci series");
int number = Convert.ToInt32(Console.ReadLine());
int perv = 1;
Console.Write("{0} ", perv);
int vtor = 1;
Console.Write("{0} ", vtor);
int sum = 0;
while (number >= sum)
            {
                sum = perv + vtor;
                
                    Console.Write("{0} ", sum);
                    
                        perv = vtor;
                        vtor = sum;                
                }
                