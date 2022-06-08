byte Vbyte = 1;
short Vshort =  32760;
int Vint = 1984;
long Vlong = 9223372036854775800;
bool Vbool1 = true;
bool Vbool2 = false;
float Vfloat = 3.14F;
double Vdouble = 0.05;
decimal Vdecimal = 334.5m;

// Operation with value:
System.Console.WriteLine("Operation with value ");
System.Console.WriteLine(Vbyte + Vshort);
System.Console.WriteLine(Vlong - Vshort);
System.Console.WriteLine(Vbyte * Vshort);
System.Console.WriteLine(Vint * Vshort);
System.Console.WriteLine(Vbool1 & Vbool2);
System.Console.WriteLine(Vbool1 || Vbool2);
System.Console.WriteLine(Vint / Vfloat);
System.Console.WriteLine(Vint / Vdouble);
System.Console.WriteLine(Vint / Vdecimal);
System.Console.WriteLine(" ");

// Math function
System.Console.WriteLine("Math function");
 
 int x = 45;
 int y = 34;

double FirstFunction  = -6 * Math.Pow(x,3) + 5 * Math.Pow(x,2) - 10 * x + 15;
System.Console.WriteLine("FirstFunction " + FirstFunction);

double SecondFunction = Math.Abs(x) * Math.Sin(x);
System.Console.WriteLine("SecondFunction " + SecondFunction);

double ThurdFunction = 2 * Math.PI * x;
System.Console.WriteLine("ThurdFunction " + ThurdFunction);

double ForthFunction = Math.Max(x,y);
System.Console.WriteLine("ForthFunction " + ForthFunction);
System.Console.WriteLine(" ");

// EXtra 
System.Console.WriteLine("Extra");
DateTime date1 = DateTime.Now;
System.Console.WriteLine("Time to new year: " +(new DateTime(2023, 1, 1) - date1));
System.Console.WriteLine("Pased time from new year: " + (date1 - new DateTime(2022, 1, 1)));