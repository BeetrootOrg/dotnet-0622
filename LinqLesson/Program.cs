using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace LinqLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            var persons = JsonConvert.DeserializeObject<IEnumerable<Person>>(File.ReadAllText("data.json"));

            //1: count males
            var males = persons.Count(persons => persons.Gender == Gender.Male);
            System.Console.WriteLine(males);

            //2: count females 
            var females = persons.Count(persons => persons.Gender == Gender.Female);
            System.Console.WriteLine(females);

            //3. youngest person
            var youngestAge = persons.Min(persons => persons.Age);
            var youngestPerson = persons.MinBy(persons => persons.Age);
            System.Console.WriteLine(youngestPerson);

            //4: oldesr person
            var oldestAge = persons.MaxBy(x => x.Age);
            System.Console.WriteLine($"Oldest Person is {oldestAge}");

			//5: all youngest
			var youngestPersons = persons.Where(x=>x.Age == youngestAge);
			System.Console.WriteLine($"There are {youngestPersons.Count()} people");

			//6: average age
			var averageAge = persons.Average(x => x.Age);
			System.Console.WriteLine($"Average age is {averageAge}");

			//7.1. count people with same eye color
			//find all and then filter
			var eyesColors = persons.Select(x=>x.EyeColor);//we get all eye colors
			var uniqueEyesColors = eyesColors.Distinct(); // get only unique eyes
			foreach(var eyeColor in uniqueEyesColors)
			{
				var countSameEyeColor = persons.Count(x => x.EyeColor == eyeColor);
				System.Console.WriteLine($"{eyeColor} has {countSameEyeColor} people");
			}

			//7.2 using GroupBy
			var eyeColorGroup = persons.GroupBy(x=>x.EyeColor);
			foreach(var item in eyeColorGroup)
			{
				System.Console.WriteLine($"{item.Key} has {item.Count()} people");
			}
        }
    }
}
