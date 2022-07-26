using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;

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

			// 5. all youngest
			var youngestPersons = persons.Where(x => x.Age == youngestAge);
			WriteLine($"There are {youngestPersons.Count()} people");

			// 6. average age
			var averageAge = persons.Average(x => x.Age);
			WriteLine($"Average age is {averageAge}");

			// 7. Person located farthest north/south/west/east
			var personNorth = persons.MaxBy(x => x.Latitude);
			var personSouth = persons.MinBy(x => x.Latitude);
			var personEast = persons.MaxBy(x => x.Longitude);
			var personWest = persons.MinBy(x => x.Longitude);

			//find max and min distance between 2 persons

			double maxDistance = 0, minDistance = 0, currentDistance = 0;
			string personMax = "", person1Max = "", personMin = "", person1Min = "";

			foreach (var person in persons)
			{
				var pLatitude = person.Latitude;
				var pLongitude = person.Longitude;

				foreach (var person1 in persons)
				{
					if (person.Name != person1.Name)
					{
						var p1Latitude = person1.Latitude;
						var p1Longitude = person1.Longitude;

						var temp1 = (p1Latitude - pLatitude) * 2;
						var temp2 = (p1Longitude - pLongitude) * 2;
						currentDistance = Math.Sqrt(temp1 + temp2);

						if (maxDistance < currentDistance)
						{
							maxDistance = currentDistance;
							personMax = person.Name;
							person1Max = person1.Name;
						}

						if (minDistance > currentDistance || minDistance == 0)
						{
							minDistance = currentDistance;
							personMin = person.Name;
							person1Min = person1.Name;
						}
					}
					

				}
			}

			// find 2 persons whos ‘about’ have the most same words
			
			int sameWords = 0;
			char[] separators = new char[] { ' ', '.' };
			string personName = "", personName1 = "";

			foreach (var person in persons)
			{
				var personAbout = person.About;

				foreach (var person1 in persons)
				{
					if (person.Name != person1.Name)
					{
						var person1AboutWords = person1.About.Split(separators, StringSplitOptions.RemoveEmptyEntries);
						var tempCount = 0;

						foreach (var word in person1AboutWords)
						{
							if (personAbout.Contains(word))
							{
								++tempCount;
							}
						}

						if (sameWords < tempCount)
						{
							sameWords = tempCount;
							personName = person.Name;
							personName1 = person1.Name;
						}
					}
				}
			}

			Console.WriteLine($"Name of first person {personName}, name for second {personName1}, same words {sameWords}");

			// find persons with same friends (compare by friend’s name)

			int sameFriends = 0;
			string personNameFriends = "", personeNameFriends1 = "";

			foreach (var person in persons)
			{
				var personFriends = person.Friends;

				foreach (var person1 in persons)
				{
					var personFriends1 = person1.Friends;

					if (person.Name != person1.Name)
					{
						var tempCount = 0;

						foreach (var friend in personFriends1)
						{
							if (personFriends.Contains(friend))
							{
								++tempCount;
							}
						}

						if (sameFriends < tempCount && sameFriends > 0)
						{
							sameFriends = tempCount;
							personNameFriends = person.Name;
							personeNameFriends1 = person1.Name;
							Console.WriteLine($"Person {personNameFriends} and person {personeNameFriends1}, have {sameFriends} same friends");
						}
						else
						{
							Console.WriteLine("Noone has shared friends");
						}
					}
				}
			}
			
		}
	}
}
