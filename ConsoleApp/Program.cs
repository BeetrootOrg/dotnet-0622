var dateTime = new DateTime(2022, 6, 8);
System.Console.WriteLine($"DateTime: {dateTime}");

var now = DateTime.Now;
System.Console.WriteLine($"Now: {now}");

var ts1 = now - dateTime;
System.Console.WriteLine($"Ellapsed from midnight: {ts1}");
TimeSpan ts = new TimeSpan(10, 5, 6);

System.Console.WriteLine($"TimeSpan {ts}");

// count day after 42 days from today
System.Console.WriteLine($"42 days after = {now + new TimeSpan(24 * 42, 0, 0)}");
System.Console.WriteLine($"42 days after = {now.AddDays(42)}");
System.Console.WriteLine($"42 days after = {now.Add(new TimeSpan(24 * 42, 0, 0))}");

// count what the day was 30 days ago
System.Console.WriteLine($"30 days before = {now - new TimeSpan(24 * 30, 0, 0)}");
System.Console.WriteLine($"30 days before = {now.AddDays(-30)}");
System.Console.WriteLine($"30 days before = {now.Subtract(new TimeSpan(24 * 30, 0, 0))}");

System.Console.WriteLine($"Year: {now.Year}");
System.Console.WriteLine($"Month: {now.Month}");
System.Console.WriteLine($"Day: {now.Day}");

DateTime date = new DateTime(DateTime.Now.Year, 12, 31);
int DaysLeft = date.Subtract(DateTime.Now).Days;
Console.WriteLine($"{++DaysLeft} bla bla bla");
