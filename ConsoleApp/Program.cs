byte byte1 = 5;
short short1 = 6;
int int1 = 15;
long long1 = 115;
bool bool1 = true;
float float1 = 15.5f;
double double1 = 15.55;
decimal decimal1 = 16.254m;

Console.WriteLine($"Here is the list of declared variables : {byte1} , {short1} , {int1} , {long1} , {bool1} , {float1} , {double1} , {decimal1}.");

double x = 15;
double result1 = (-6 * Math.Pow(x, 3)) + (5 * Math.Pow(x, 2) - 10 * x + 15);
double result2 = Math.Abs(x) * Math.Sin(x);
double result3 = 2 * Math.PI * x;
double result4 = Math.Max(x , 28);

Console.WriteLine($"Here is the list of results : {result1} , {result2} , {result3} , {result4}.");

DateTime date = new DateTime(DateTime.Now.Year, 12, 31);
int DaysLeft = date.Subtract(DateTime.Now).Days;
Console.WriteLine($"{DaysLeft + 1} days left to New Year.");
DateTime currentDateTime = DateTime.Now;
Console.WriteLine($"{currentDateTime.DayOfYear} days passed from New Year.");

