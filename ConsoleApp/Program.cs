using static System.Console;
//using System.Collections.Generic;

void Swap<T>(ref T val1, ref T val2);
{
    var temp = val1;
    val1 = val2;
    val2 = temp;
}

var a = 1;
var b = 3;

Swap(ref a, ref b);

