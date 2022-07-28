using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;

using static System.Console;

namespace LinqLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            var persons = JsonConvert.DeserializeObject<IEnumerable<Person>>(File.ReadAllText("data.json"));
            //1 - Count males
            var males = persons.Count(person => person.Gender == Gender.Male);
            WriteLine($"Males: {males}");

            //2 - Count Females
            var females = persons.Count(person => person.Gender == Gender.Female);
            WriteLine($"Females: {females}");

            //3 -youngest person
            var youngestPerson = persons.MinBy(person => person.Age);
            var youngestAge = persons.Min(person => person.Age);
            WriteLine($"Youngest person is: {youngestPerson}");

            //4 - oldest person
            var oldestPerson = persons.MaxBy(person => person.Age);
            WriteLine($"Oldest person is: {oldestPerson}");

            //5 - all youngest persons
            var youngestPersons = persons.Where(person => person.Age == youngestAge);
            WriteLine($"There are {youngestPersons.Count()} people");

            //6 - avarage age
            var avarageAge = persons.Average(person => person.Age);
            WriteLine($"Avarage age {avarageAge}");

            //7.1 - count people with same eye color
            var eyesColors = persons.Select(x => x.EyeColor);
            var uniqueEyeColors = eyesColors.Distinct();
            foreach (var eyeColor in uniqueEyeColors)
            {
                var CountSameEyeColor = persons.Count(x => x.EyeColor == eyeColor);
                WriteLine($"{eyeColor} has {CountSameEyeColor} people");
            }
            //7.2 - count people with same eye color
            var eyesColorGroup = persons.GroupBy(x => x.EyeColor);
            foreach (var item in eyesColorGroup)
            {
                WriteLine($"{item.Key} has {item.Count()} people");
            }
        }
    }
}
