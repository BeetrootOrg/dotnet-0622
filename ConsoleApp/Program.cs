using static System.Console;

void Swap<T>(ref T val1, ref T val2)
{
    var temp = val1;
    val1 = val2;
    val2 = temp;
}

var a = 1;
var b = 2;
Swap(ref a, ref b);

WriteLine($"a = {a}");
WriteLine($"b = {b}");

var c = "hello";
var d = "world";

Swap(ref c, ref d);

WriteLine($"c = {c}");
WriteLine($"d = {d}");
