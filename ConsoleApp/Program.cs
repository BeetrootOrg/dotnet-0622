// Defining variables
byte myByte = 1;
short myShort = 10;
int myInt = 101;
long myLong = 1000;
bool myBool = true;
bool myFalseBool = false;
float myFloat = 0.1f;
double myDouble = 0.01;
decimal myDecimal = 0.001m;

// Math and logical operations to defined variables
System.Console.WriteLine(myByte + myLong);
System.Console.WriteLine(myShort - myFloat);
System.Console.WriteLine(myInt * myDecimal);
System.Console.WriteLine(myBool || myFalseBool);
System.Console.WriteLine(myDouble / myInt);
System.Console.WriteLine(myInt % myShort);

// Math function 1
double x = -15;
double firstFunctionResult = -6 * Math.Pow(x,3) + 5 * Math.Pow(x, 2) - 10 * x + 15;
System.Console.WriteLine(firstFunctionResult);

// Math function 2
double secondFunctionResult = Math.Abs(x) * Math.Sin(x);
System.Console.WriteLine(secondFunctionResult);

//Math function 3
double thirdFunctionResult = 2 * Math.PI * x;
System.Console.WriteLine(thirdFunctionResult);

//Math function 4
double y = 144;
double fourthFunctionResult = Math.Max(x, y);
System.Console.WriteLine(fourthFunctionResult);

//DateTime: countdown to New Year
DateTime today = DateTime.Today;
DateTime newYearDate = new DateTime(2023, 1, 1);

int daysToNewYear = (newYearDate - today).Days;
int daysInCurrentYear = DateTime.IsLeapYear(today.Year) ? 366 : 365;
int daysPassedFromNewYear = daysInCurrentYear - daysToNewYear;

System.Console.WriteLine($"{daysToNewYear} days left to New Year");
System.Console.WriteLine($"{daysPassedFromNewYear} days passed from New Year");