Console.Write("x = ");
int x;
try {
    x = Convert.ToInt32(Console.ReadLine());
} catch {
    Console.WriteLine("Invalid input");
    return;
}

Console.Write("y = ");
int y;
try {
    y = Convert.ToInt32(Console.ReadLine());
} catch {
    Console.WriteLine("Invalid input");
    return;
}
// Also i could add filter for negative input values if it necessary

int sum = 0;
Console.Write("Sum = ");
if (x > y) {
    for (int i = y; i<=x; i++) {
        sum += i;
        if (i == x)
            Console.Write(i);
        else
            Console.Write(i + " + ");
    }
} else {    
    for (int i = x; i<=y; i++) {
        sum += i;        
        if (i == y)
            Console.Write(i);
        else
            Console.Write(i + " + ");
    }
}

Console.Write(" = " + sum);