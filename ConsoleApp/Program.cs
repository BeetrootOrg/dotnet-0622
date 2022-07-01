using ConsoleApp.AutoSrvice;


var empl1 = new Employee { FirstName = "Tom", LastName = "Baiden", Salary = 1000 };
var client1 = new Client {FirstName = "Bob",LastName= "Poter", PhoneNumber = "+777777777"};

var car1 = new Audi{RegistrationNumber = 42, Year = 2020, ModelName = "A4", EngineCapacity = 1998, GearType = GearType.Automat, NumberDoors = 5};

car1.CarSound();