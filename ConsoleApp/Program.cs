byte b1 = 5;
short s1 = 6;
int i1 = 7;
long l1 = 129030192;
bool b2 = true;
float f1 = 123.01f;
double d1 = 123.01d;
decimal d2 = 400.75m;

Console.WriteLine((l1-s1)+(i1*b1));

int x = 15;
int y = 10;
Console.WriteLine(-6*x^3+5*x^2-10*x+15);
Console.WriteLine(Math.Abs(x)*Math.Sin(x));
Console.WriteLine(2*Math.PI*x);
Console.WriteLine(Math.Max(x, y));

DateTime now = DateTime.Now;
DateTime NewYear = new DateTime(DateTime.Now.Year,12,31);

int x1 = NewYear.DayOfYear - now.DayOfYear;
int y1 = now.DayOfYear;

Console.WriteLine(x1+" days left to New Year");
Console.WriteLine(y1+" days passed from New Year");

