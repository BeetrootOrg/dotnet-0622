// See https://aka.ms/new-console-template for more information
DateTime dateNow = DateTime.Now;
DateTime lastDayOfYear = new DateTime(DateTime.Now.Year, 12, 31);
int x = lastDayOfYear.DayOfYear - dateNow.DayOfYear;
int y = dateNow.DayOfYear;
Console.WriteLine("days left to New Year (x = " + x + ")\ndays passed from New Year (y = " + y + ")");

Console.WriteLine("-6*x^3+5*x^2-10*x+15 = " + (-6*Math.Pow(x,3)+5*Math.Pow(x,2)-10*x + 15));
Console.WriteLine("abs(x)*sin(x) = " + Math.Abs(x)*Math.Sin(x));
Console.WriteLine("2*pi*x = " + 2*Math.PI*x);
Console.WriteLine("max(x, y) = " + Math.Max(x,y));