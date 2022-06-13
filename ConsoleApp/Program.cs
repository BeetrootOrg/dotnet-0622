byte variableByte = 12;
short variableShort = 255;
int variableInt = 5045;
long variableLong = 4890238;
bool variableBool = true;
char variableChar = '!';
float variableFloat = 0.1f;
double variableDouble = 0.345;
decimal variableDecimal = 0.64578697m;
string variableString = "Hi";

Console.WriteLine("Division: ");
decimal div = variableDecimal / variableInt;
Console.WriteLine(div);
Console.WriteLine();

Console.WriteLine("Multiplication: ");
double mult = variableDouble * variableFloat;
Console.WriteLine(mult);
Console.WriteLine();

Console.WriteLine("Concatenation: ");
string conc = variableString + variableChar;
Console.WriteLine(conc);
Console.WriteLine();

Console.WriteLine("Exclusive OR: ");
int exOR = variableShort ^ variableByte;
Console.WriteLine(exOR);
Console.WriteLine();

Console.WriteLine("Even");
bool even = variableLong % 2 == 0 ? variableBool : false;
Console.WriteLine(even);
Console.WriteLine();

Console.WriteLine("Negation: ");
Console.WriteLine(!variableBool);
Console.WriteLine();



Console.WriteLine("Enter the number for x: ");
int x;
int.TryParse(Console.ReadLine(), out x);

//operation #1
double resOfOperation_1 = -6 * x ^ 3 + 5 * x ^ 2 - 10 * +15;
Console.WriteLine(resOfOperation_1);

//operation #2
double resOfOperation_2 = Math.Abs(x) * Math.Sin(x);
Console.WriteLine(resOfOperation_2);

//operation #3
double resOfOperation_3 = 2 * Math.PI * x;
Console.WriteLine(resOfOperation_3);

Console.WriteLine("Enter the number for y: ");
int y;
int.TryParse(Console.ReadLine(), out y);

//operation #4
double resOfOperation_4 = Math.Max(x, y);
Console.WriteLine("Max: " + resOfOperation_4);


//Extra

//Now
var now = DateTime.Now;
Console.WriteLine($"Now: {now}");

//New Year
var newYear = new DateTime(2022, 1, 1);
Console.WriteLine($"New Year: {newYear}");


//Amount of days passed from New Year
var amOfDaysAfter = now - newYear;
Console.WriteLine($"{amOfDaysAfter.Days} days passed from New Year");

//Amount of days left to New Year
newYear = newYear.AddYears(1);
var amOfDaysBefore = newYear - now;
 Console.WriteLine($"{amOfDaysBefore.Days} days left to New Year");