void CharCheck(char symbol)
{
    System.Console.WriteLine($"Checking symbol {symbol}:");
    System.Console.WriteLine($"\t- Is ASCII = {char.IsAscii(symbol)}");
    System.Console.WriteLine($"\t- Is Digit = {char.IsDigit(symbol)}");
    System.Console.WriteLine($"\t- Is Letter = {char.IsLetter(symbol)}");
    System.Console.WriteLine($"\t- Is Lower = {char.IsLower(symbol)}");
    System.Console.WriteLine($"\t- Is Upper = {char.IsUpper(symbol)}");
    System.Console.WriteLine($"\t- Is Number = {char.IsNumber(symbol)}");
    System.Console.WriteLine($"\t- Is Punctuation = {char.IsPunctuation(symbol)}");
}

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

// check chars
CharCheck('a');
CharCheck('A');
CharCheck('1');
CharCheck(',');
CharCheck('/');
CharCheck('\u1234');

// transformations
System.Console.WriteLine("TRANSFORMATIONS");
System.Console.WriteLine(char.ToLower('A'));
System.Console.WriteLine(char.ToUpper('a'));

var str = "some string";
System.Console.WriteLine(str);

// new line string
var str1 = "Long text\r\n" + "next line.";
var str2 = "Long text\r\nnext line.";
var str3 = @"Long text
next line.";

System.Console.WriteLine(str1 == str2);
System.Console.WriteLine(str2 == str3);

// put variable in string
var a = 1;
var b = 2;
var sum = a + b;

System.Console.WriteLine("SUM");
System.Console.WriteLine(a + "+" + b + "=" + sum);
System.Console.WriteLine(string.Format("{0}+{1}={2}", a, b, sum));
System.Console.WriteLine($"{a}+{b}={sum}");

System.Console.WriteLine("BACKSLASH");
System.Console.WriteLine(@"\");
System.Console.WriteLine("\\");
System.Console.WriteLine("\\n");
System.Console.WriteLine(@"\n");
System.Console.WriteLine($"{'\\'}{'n'}");

// methods in string
