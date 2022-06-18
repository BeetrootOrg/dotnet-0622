// the same below
var c1 = 'a';
var c2 = '\u0061';

System.Console.WriteLine(c1);
System.Console.WriteLine(c2);

// new line
var c3 = '\n';
System.Console.WriteLine(c3);
System.Console.WriteLine("new line above");

// random symbol
var c4 = '\u05F0';
System.Console.WriteLine(c4);

// equals
System.Console.WriteLine("EQUALITY");
System.Console.WriteLine('a' == 'a');
System.Console.WriteLine('b' > 'a');
System.Console.WriteLine('a' < 'c');
System.Console.WriteLine('A' < 'a');