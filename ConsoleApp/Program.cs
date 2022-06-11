// some code gonna be here tomo
const int N = 5;
var result = 0;

int f1 = 0;
int f2 = 1;


for (int i = 0; i < N; i++)
{   
    
    result = f1 + f2;
    Console.WriteLine($"Fibonacci number is {result}");
    f1 = f2;
    f2 = result;
    
    
}

Console.WriteLine($"{N}-th Fibonacci number is {result}");