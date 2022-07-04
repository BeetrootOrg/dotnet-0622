using ConsoleApp;

System.Console.WriteLine("Hello");

var carBuilder = new CarBuilder();

var car = carBuilder.SetColor("black")
    .SetName("Nissan")
    .SetPower(119)
    .Build();