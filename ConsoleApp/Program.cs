byte b1 = 10;
short s1 = 20;
int i1 = 30;
long l1 = 40;
bool b2 = false;
float f1 = 50.1f;
double d1 = 50.2;
decimal d2 = 50.3m;
char c1 = '/';

System.Console.WriteLine($"byte:{b1}, short:{s1}, int:{i1}, long:{l1}, bool:{b2}, float:{f1}, double:{d1}, decimal:{d2}, char{c1}");


var x = 5;
var y = 10;
//-6*x^3+5*x^2-10*x+15
System.Console.WriteLine(-6 * x ^ 3 + 5 * x ^ 2 - 10 * x + 15);
//abs(x)*sin(x)
System.Console.WriteLine(Math.Abs(x) * Math.Sin(x));
//2*pi*x
System.Console.WriteLine(2 * Math.PI * x);
// max(x, y)
System.Console.WriteLine(Math.Max(x, y));


// X days left to New Year

// Y days passed from New Year
DateTime presentDay = DateTime.Today;
int day = presentDay.DayOfYear;
System.Console.WriteLine($"present day: {presentDay.DayOfYear}");

int daysInYear = 365;
System.Console.Write("enter present year: ");
var year = Convert.ToInt32(Console.ReadLine());

if (DateTime.IsLeapYear(year))
{
    ++daysInYear;
    System.Console.WriteLine($"{year} is leap year");
}
else
{
    System.Console.WriteLine($"{year} is not leap year");
}

System.Console.WriteLine($"{daysInYear - day} days left to New Year");
//System.Console.WriteLine($"{day} days passed from New Year");

