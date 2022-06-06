Console.WriteLine("---------------------------------------------------");

byte b1=1, b2=2;
Console.WriteLine("byte");
Console.WriteLine("b1 + b2 = "+(b1+b2));
Console.WriteLine("b1 - b2 = "+(b1-b2));
Console.WriteLine("b1 * b2 = "+(b1*b2));
Console.WriteLine("---------------------------------------------------");

short s1=123, s2=13123;
Console.WriteLine("short");
Console.WriteLine("s1 + s2 = "+(s1+s2));
Console.WriteLine("s1 - s2 = "+(s1-s2));
Console.WriteLine("s1 * s2 = "+(s1*s2));
Console.WriteLine("---------------------------------------------------");

int i1=345, i2=53456;
Console.WriteLine("int");
Console.WriteLine("i1 + i2 = "+(i1+i2));
Console.WriteLine("i1 - i2 = "+(i1-i2));
Console.WriteLine("i1 * i2 = "+(i1*i2));
Console.WriteLine("---------------------------------------------------");

long l1=3956, l2=234;
Console.WriteLine("long");
Console.WriteLine("l1 + l2 = "+(l1+l2));
Console.WriteLine("l1 - l2 = "+(l1-l2));
Console.WriteLine("l1 * l2 = "+(l1*l2));
Console.WriteLine("---------------------------------------------------");

float f1=546.483f, f2=5535.17484f;
Console.WriteLine("float");
Console.WriteLine("f1 + f2 = "+(f1+f2));
Console.WriteLine("f1 - f2 = "+(f1-f2));
Console.WriteLine("f1 * f2 = "+(f1*f2));
Console.WriteLine("---------------------------------------------------");

double d1=345.48, d2=34534.1867;
Console.WriteLine("double");
Console.WriteLine("d1 + d2 = "+(d1+d2));
Console.WriteLine("d1 - d2 = "+(d1-d2));
Console.WriteLine("d1 * d2 = "+(d1*d2));
Console.WriteLine("---------------------------------------------------");

decimal m1=486.78m, m2=8738.15m;
Console.WriteLine("decimal");
Console.WriteLine("d1 + d2 = "+(d1+d2));
Console.WriteLine("d1 - d2 = "+(d1-d2));
Console.WriteLine("d1 * d2 = "+(d1*d2));
Console.WriteLine("---------------------------------------------------");

bool bool1=true, bool2=false;
Console.WriteLine("bool");
Console.WriteLine("bool1 & bool2 = " + (bool1 & bool2));
Console.WriteLine("bool1 | bool2 = " + (bool1 | bool2));
Console.WriteLine("!bool1 = " + !bool1);
Console.WriteLine("---------------------------------------------------");

Console.Write("x = ");
double x = Convert.ToDouble(Console.ReadLine());
Console.Write("y = ");
double y = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("-6*x^3+5*x^2-10*x+15 = " + (-6*Math.Pow(x,3)+5*Math.Pow(x,2)-10*x + 15));
Console.WriteLine("abs(x)*sin(x) = " + Math.Abs(x)*Math.Sin(x));
Console.WriteLine("2*pi*x = " + 2*Math.PI*x);
Console.WriteLine("max(x, y) = " + Math.Max(x,y));
Console.WriteLine("---------------------------------------------------");

DateTime dateNow = DateTime.Now;
DateTime lastDayOfYear = new DateTime(DateTime.Now.Year, 12, 31);
Console.WriteLine(lastDayOfYear.DayOfYear - dateNow.DayOfYear + " days left to New Year");
Console.WriteLine(dateNow.DayOfYear + " days passed from New Year");
Console.WriteLine("---------------------------------------------------");