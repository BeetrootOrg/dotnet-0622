byte byteVariable = 255;
short shortVariable = 32767;
int intVariable = 2147483647;
long longVariable = 9223372036854775807;
bool boolVariable = true;
char charVariable = 'S';
float floatVariable = 38382.34f;
double doubleVariable = 2881811.302032;
decimal decimalVariable = 3283228.23288283M;
string stringVariable = "[Some string]";


Console.WriteLine($"byteVariable is {byteVariable}");
Console.WriteLine($"shortVariable is {shortVariable}");
Console.WriteLine($"--intVariable is {++intVariable}"); 
Console.WriteLine($"longVariable is {longVariable}");
Console.WriteLine($"boolVariable is {boolVariable}");
Console.WriteLine($"charVariable is {charVariable}");
Console.WriteLine($"floatVariable is {floatVariable + 3.6}");
Console.WriteLine($"doubleVariable is {doubleVariable * 10}");
Console.WriteLine($"decimalVariable is {decimalVariable}");
Console.WriteLine($"stringVariable is {stringVariable}");

Console.WriteLine("Here are also some math functions");
double x = 3.1;
double result;

result = -6 * Math.Pow(x,3) + 5 * Math.Pow(x,2) - 10 * x + 15;
Console.WriteLine($"if x={x}, then result of -6*x^3+5*x^2-10*x+15={result}");

//sin(x);
double degrees = 180;
double angle = Math.PI * degrees / 180.0;
double resultSinX = Math.Sin(angle);
Console.WriteLine($"if x={degrees} deg, then abs(x)*sin(x)={Math.Abs(degrees)*resultSinX}");

double pixResult = 2 * Math.PI * 10;
Console.WriteLine($"if x= 10, then 2*pi*x={pixResult}");
Console.WriteLine("The highest number if x=5 and y=20 is " + Math.Max(5, 20)); 

void GetNewYearDays()
{
    //DateTime localDate=DateTime.Now;
    DateTime localDate = DateTime.Today;
    
    Console.WriteLine($"It's {localDate.DayOfYear} day of this Year");
    
    int daysAmount = 365;
    if (DateTime.IsLeapYear(localDate.Year))
    {
        daysAmount = 366;
    } 
    
    Console.WriteLine($"The number of days until New Year is {daysAmount-localDate.DayOfYear}");
}


GetNewYearDays();