Console.Write("x = ");
int x;
var buffer = Console.ReadLine();
if (!int.TryParse(buffer, out x)) {
    Console.WriteLine("Invalid input");
    return;
}

int y;
Console.Write("y = ");
buffer = Console.ReadLine();
if (!int.TryParse(buffer, out y)) {
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