var dateTime = new DateTime(2022, 6, 8);
System.Console.WriteLine($"DateTime: {dateTime}");

var now = DateTime.Now;
System.Console.WriteLine($"Now: {now}");

System.Console.WriteLine($"Ellapsed from midnight: {now - dateTime}");