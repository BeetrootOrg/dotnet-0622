const int N = 1;
var result = 0;

var prev = 1;
result = 1;
var counter = N - 1;

while (--counter > 0)
{
    var temp = result;
    result += prev;
    prev = temp;
}

Console.WriteLine($"{N}-th Fibonacci number is {result}");