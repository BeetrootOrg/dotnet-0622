using System;
using System.Threading;

using static System.Console;

void CharCheck(char symbol)
{
    WriteLine($"Checking symbol {symbol}:");
    WriteLine($"\t- Is ASCII = {char.IsAscii(symbol)}");
    WriteLine($"\t- Is Digit = {char.IsDigit(symbol)}");
    WriteLine($"\t- Is Letter = {char.IsLetter(symbol)}");
    WriteLine($"\t- Is Lower = {char.IsLower(symbol)}");
    WriteLine($"\t- Is Upper = {char.IsUpper(symbol)}");
    WriteLine($"\t- Is Number = {char.IsNumber(symbol)}");
    WriteLine($"\t- Is Punctuation = {char.IsPunctuation(symbol)}");
}

// the same below
var c1 = 'a';
var c2 = '\u0061';

WriteLine(c1);
WriteLine(c2);

// new line
var c3 = '\n';
WriteLine(c3);
WriteLine("new line above");

// random symbol
var c4 = '\u05F0';
WriteLine(c4);

// equals
WriteLine("EQUALITY");
WriteLine('a' == 'a');
WriteLine('b' > 'a');
WriteLine('a' < 'c');
WriteLine('A' < 'a');

// check chars
CharCheck('a');
CharCheck('A');
CharCheck('1');
CharCheck(',');
CharCheck('/');
CharCheck('\u1234');

// transformations
WriteLine("TRANSFORMATIONS");
WriteLine(char.ToLower('A'));
WriteLine(char.ToUpper('a'));

var str = "some string";
WriteLine(str);

// new line string
var str1 = "Long text\r\n" + "next line.";
var str2 = "Long text\r\nnext line.";
var str3 = @"Long text
next line.";

WriteLine(str1 == str2);
WriteLine(str2 == str3);

// put variable in string
var a = 1;
var b = 2;
var sum = a + b;

WriteLine("SUM");
WriteLine(a + "+" + b + "=" + sum);
WriteLine(string.Format("{0}+{1}={2}", a, b, sum));
WriteLine($"{a}+{b}={sum}");

WriteLine("BACKSLASH");
WriteLine(@"\");
WriteLine("\\");
WriteLine("\\n");
WriteLine(@"\n");
WriteLine($"{'\\'}{'n'}");

// methods in string
var test1 = "test REAL TEST";
var test2 = "TEST real test";
WriteLine($"Testing string {test1}");
WriteLine($"\tClone() = {test1.Clone()}");
WriteLine($"\t't'.CompareTo('T') = {'t'.CompareTo('T')}");
WriteLine($"\tCompareTo('{test2}') = {test1.CompareTo(test2)}");
WriteLine($"\tContains('e') = {test1.Contains('e')}");
WriteLine($"\tContains('te') = {test1.Contains("te")}");
WriteLine($"\tContains('b') = {test1.Contains('b')}");
WriteLine($"\tContains('be') = {test1.Contains("be")}");
WriteLine($"\tEndsWith('st') = {test1.EndsWith("st")}");
WriteLine($"\tEndsWith('ST') = {test1.EndsWith("ST")}");
WriteLine($"\tEndsWith('ST', OrdinalIgnoreCase) = {test1.EndsWith("ST", StringComparison.OrdinalIgnoreCase)}");
WriteLine($"\tIndexOf('e') = {test1.IndexOf('e')}");
WriteLine($"\tIndexOf('E') = {test1.IndexOf('E')}");
WriteLine($"\tLastIndexOf('e') = {test1.LastIndexOf('e')}");
WriteLine($"\tLastIndexOf('E') = {test1.LastIndexOf('E')}");
WriteLine($"\tIndexOf('e', 2) = {test1.IndexOf('e', 2)}");
WriteLine($"\tLastIndexOf('te', 2) = {test1.LastIndexOf("te", StringComparison.OrdinalIgnoreCase)}");
WriteLine($"\tInsert(6, '<<inserted>>') = {test1.Insert(6, "<<inserted>>")}");
WriteLine($"\tReplace('REAL', '<<inserted>>') = {test1.Replace("REAL", "<<inserted>>")}");
WriteLine($"\tPadLeft(30) = {test1.PadLeft(30)}");
WriteLine($"\tRemove(5, 4) = {test1.Remove(5, 4)}");
WriteLine($"\tSubstring(5, 4) = {test1.Substring(5, 4)}");
WriteLine($"\ttest1[5..9] = {test1[5..9]}");
WriteLine($"\tToLower() = {test1.ToLower()}");
WriteLine($"\tToUpper() = {test1.ToUpper()}");
WriteLine($"\tTrim('t') = {test1.Trim('t')}");

// string equality
WriteLine("Equality:");
WriteLine($"'{test1}'=='{test2}'={test1 == test2}");
WriteLine($"'{test1}'.Equals('{test2}')={test1.Equals(test2)}");
WriteLine($"string.Equals('6', 6)={string.Equals("6", 6)}");
WriteLine($"string.Equals('{test1}', '{test2}')={string.Equals(test1, test2)}");
WriteLine($"string.Equals('{test1}', '{test2}', OrdinalIgnoreCase)={string.Equals(test1, test2, StringComparison.OrdinalIgnoreCase)}");
WriteLine($"'6'.Equals(6)={"6".Equals(6)}");

WriteLine(Thread.CurrentThread.CurrentCulture);
WriteLine(DateTime.Now.ToString());