//define some variables

byte bt = 88;
short shrt = 111;
int i = 222;
long lng = 232323232323;
float flt = 888.88f;
double dbl = 567.32323;
decimal dcm = 8M;

System.Console.WriteLine("---result of some simple operations---");
System.Console.WriteLine(lng + shrt);
System.Console.WriteLine(i - flt);
System.Console.WriteLine(shrt * dcm);
System.Console.WriteLine(dbl % bt);
System.Console.WriteLine();

//math functions

int x = 8;
int y = 12345;
System.Console.WriteLine("---Math functions---");
System.Console.WriteLine(-6 * Math.Pow(x, 3) + 5 * Math.Pow(x, 2) - 10 * x + 15);
System.Console.WriteLine(Math.Abs(x) * Math.Sin(x));
System.Console.WriteLine(2 * Math.PI * x);
System.Console.WriteLine(Math.Max(x, y));

// NewYear date time

var now = DateTime.Today.DayOfYear;
var DaysInYear = 365;
System.Console.WriteLine("---DateTime operations---");
System.Console.WriteLine($"{++DaysInYear - now} days left to New Year");
System.Console.WriteLine($"{--now} days passed from New Year");
