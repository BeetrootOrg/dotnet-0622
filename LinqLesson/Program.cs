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

			//// 1. count males
			//var males = persons.Count(person => person.Gender == Gender.Male);
			//WriteLine($"Males: {males}");

			//// 2. count females
			//var females = persons.Count(person => person.Gender == Gender.Female);
			//WriteLine($"Females: {females}");

			//// 3. youngest person
			//var youngestAge = persons.Min(person => person.Age);
			//var youngestPerson = persons.MinBy(person => person.Age);
			//WriteLine($"Youngest person is {youngestPerson}");

			//// 4. oldest person
			//var oldestPerson = persons.MaxBy(x => x.Age);
			//WriteLine($"Oldest person is {oldestPerson}");

			//// 5. all youngest
			//var youngestPersons = persons.Where(x => x.Age == youngestAge);
			//WriteLine($"There are {youngestPersons.Count()} people");

			//// 6. average age
			//var averageAge = persons.Average(x => x.Age);
			//WriteLine($"Average age is {averageAge}");

			//// 7.1. count people with same eye color
			//var eyesColors = persons.Select(x => x.EyeColor);
			//var uniqueEyesColors = eyesColors.Distinct();
			//foreach (var eyeColor in uniqueEyesColors)
			//{
			//	var countSameEyeColor = persons.Count(x => x.EyeColor == eyeColor);
			//	WriteLine($"{eyeColor} has {countSameEyeColor} people");
			//}

			//// 7.2. 
			//var eyeColorsGroup = persons.GroupBy(x => x.EyeColor);
			//foreach (var item in eyeColorsGroup)
			//{
			//	WriteLine($"{item.Key} has {item.Count()} people");
			//}

			// 8. common tags



			//var allTagsSelected = persons.Select(x => x.Tags);
			//var allTags = persons.SelectMany(x => x.Tags);
			//var tagsGroups = allTags.GroupBy(x => x);
			//var mainTag = tagsGroups.MaxBy(x => x.Count()).Key;

			//var personsWithSameTag = persons.Where(x => x.Tags.Contains(mainTag)).Count();
			//WriteLine($"Persons with same tag '{mainTag}' are {personsWithSameTag}");

			//Part1
			var MaxLatitudePerson = persons.MaxBy(x => x.Latitude);

			System.Console.WriteLine($"Northest person is {MaxLatitudePerson.Name}, latitude is {MaxLatitudePerson.Latitude}");

			var MinLatitudePerson = persons.MinBy(x => x.Latitude);

			System.Console.WriteLine($"Southest person is {MinLatitudePerson.Name}, latitude is {MinLatitudePerson.Latitude}");

			var MinLLongitudePerson = persons.MinBy(x => x.Longitude);

			System.Console.WriteLine($"Westest person is {MinLLongitudePerson.Name}, longitude is {MinLLongitudePerson.Longitude}");

			var MaxLongitudePerson = persons.MaxBy(x => x.Longitude);

			System.Console.WriteLine($"Eastest person is {MaxLongitudePerson.Name}, longitude is {MaxLongitudePerson.Longitude}");

			//Part2

			System.Console.WriteLine($"Max distance between 2 persons in list is {(int)MaxDistance(persons)}");

			System.Console.WriteLine($"Min distance between 2 persons in list is {(int)MinDistance(persons)}");

			//Part3
			var allAbouts = persons.Select(x => x.About.Split());

			var personslist = persons.ToList();

			var allaboutslist = allAbouts.ToList();

			int counter = 0;

			int[] indexer = new int[2];


			for (int i = 0; i < allaboutslist.Count - 1; i++)
			{
				for (int j = i + 1; j < allaboutslist[j].Length; j++)
				{
					if ((allaboutslist[i].Intersect(allaboutslist[j])).Count() > counter)
					{
						counter = (allaboutslist[i].Intersect(allaboutslist[j])).Count();
						indexer[0] = i;
						indexer[1] = j;
					}

				}
			}

            System.Console.WriteLine($"{personslist[indexer[0]].Name} and {personslist[indexer[1]].Name} has {counter} same words in Abouts");

			//Part4

		}
		public static double CalculateDistance(Person person1, Person person2)
		{

			var  EarthRadius = 6372795;
			//toRadians

			var lat1 = person1.Latitude * 3.14 / 180;
			var lat2 = person2.Latitude * 3.14 / 180;
			var long1 = person1.Longitude * 3.14 / 180;
			var long2 = person2.Longitude * 3.14 / 180;

			//cos and sins
			var coslat1 = System.Math.Cos(lat1);
			var coslat2 = System.Math.Cos(lat2);
			var sinlat1 = System.Math.Sin(lat1);
			var sinlat2 = System.Math.Sin(lat2);

			var delta = (long1 - long2);

			var cosdelta = System.Math.Cos(delta);
			var sindelta = System.Math.Sin(delta);

			// big circle length

			var y = System.Math.Sqrt(System.Math.Pow(coslat2 * sindelta, 2) + System.Math.Pow(coslat1 * sinlat2 - sinlat1 * coslat2 * cosdelta, 2));

			var x = sinlat1 * sinlat2 + coslat1 * coslat2 * cosdelta;

			var ad = System.Math.Atan2(y, x);

			var dist = ad * EarthRadius;

			return dist;
		}

		public static double MaxDistance(IEnumerable<Person> persons)
		{
			var personslist = persons.ToList();

			double MaxDistance = double.MinValue;

            for (int i = 0; i < personslist.Count; i++)
            {
                for (int j = i + 1; j < personslist.Count; j++)
                {
					if (CalculateDistance(personslist[i], personslist[j]) > MaxDistance)
					{
						MaxDistance = CalculateDistance(personslist[i], personslist[j]);
					}
				}
            }
			return MaxDistance;
		}

		public static double MinDistance(IEnumerable<Person> persons)
		{
			var personslist = persons.ToList();

			double MinDistance = double.MaxValue;

			for (int i = 0; i < personslist.Count; i++)
			{
				for (int j = i + 1; j < personslist.Count; j++)
				{
					if (CalculateDistance(personslist[i], personslist[j]) < MinDistance)
					{
						MinDistance = CalculateDistance(personslist[i], personslist[j]);
					}
				}
			}
			return MinDistance;
		}
	}
}
