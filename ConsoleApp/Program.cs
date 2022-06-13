var random  = new Random((int)DateTime.Now.Ticks);
System.Console.WriteLine(random.Next());
System.Console.WriteLine(random.Next(100));
System.Console.WriteLine(random.Next(50, 150));
System.Console.WriteLine(random.NextDouble());
//from 30 to 100 [30; 100)
System.Console.WriteLine(random.NextDouble() * 70 + 30); // random * (length of values) + minValue

//from 0 to 100 [0; 100)
System.Console.WriteLine(random.NextDouble()* 100);

//something with probability 10%
var chance = random.NextDouble() * 100;
