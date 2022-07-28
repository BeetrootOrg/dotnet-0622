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

			// 1. count males
			var males = persons.Count(person => person.Gender == Gender.Male);
			WriteLine($"Males: {males}");

			// 2. count females
			var females = persons.Count(person => person.Gender == Gender.Female);
			WriteLine($"Females: {females}");

			// 3. youngest person
			var youngestAge = persons.Min(person => person.Age);
			var youngestPerson = persons.MinBy(person => person.Age);
			WriteLine($"Youngest person is {youngestPerson}");

			// 4. oldest person
			var oldestPerson = persons.MaxBy(x => x.Age);
			WriteLine($"Oldest person is {oldestPerson}");

			// 5. the southernmost person 
			var southernmosttPerson = persons.Min(x => x.Latitude);
			WriteLine($"The southernmost person is {southernmosttPerson}");

			// 6. the northernmost person
			var northernmostPerson = persons.Max(x => x.Latitude);
			WriteLine($"The northernmost person is {northernmostPerson}");

			// 7. the westernmost person
			var westernmostPerson = persons.Min(x => x.Longitude);
			WriteLine($"The westernmost person is {westernmostPerson}");

			//  8. the easternmost person
			var esternmosttPerson = persons.Max(x => x.Longitude);
			WriteLine($"The easternmost person is {esternmosttPerson}");

			// 9. max distance between 2 persons 
			

		}
	}
}
