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
		private static double Distance(Person person1, Person person2)
		{
			//double a = Math.Sin(((person2.Latitude - person1.Latitude)*Math.PI/180)/2)*Math.Sin(((person2.Latitude - person1.Latitude)*Math.PI/180)/2) + Math.Cos(person1.Latitude*Math.PI/180)*Math.Cos(person2.Latitude*Math.PI/180)*Math.Sin(((person2.Longitude - person1.Longitude)*Math.PI/180)/2)*Math.Sin(((person2.Longitude - person1.Longitude)*Math.PI/180)/2);
			//return 2*6371*Math.Atan2(Math.Sqrt(a),Math.Sqrt(1-a));
			double phi1 = person1.Latitude * Math.PI/180;
			double phi2 = person2.Latitude * Math.PI/180;
			double dphi = phi2 - phi1;
			double dlambda = (person2.Longitude-person1.Longitude)*Math.PI/180;
			double a = Math.Sin(dphi/2)*Math.Sin(dphi/2) + Math.Cos(phi1)*Math.Cos(phi2)*Math.Sin(dlambda/2)*Math.Sin(dlambda/2);
			return 6371*2*Math.Atan2(Math.Sqrt(a), Math.Sqrt(1-a)); 
		}		

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

			// 7.1. count people with same eye color
			var eyesColors = persons.Select(x => x.EyeColor);
			var uniqueEyesColors = eyesColors.Distinct();
			foreach (var eyeColor in uniqueEyesColors)
			{
				var countSameEyeColor = persons.Count(x => x.EyeColor == eyeColor);
				WriteLine($"{eyeColor} has {countSameEyeColor} people");
			}

			// 7.2. 
			var eyeColorsGroup = persons.GroupBy(x => x.EyeColor);
			foreach (var item in eyeColorsGroup)
			{
				WriteLine($"{item.Key} has {item.Count()} people");
			}

			//homework
			//find out who is located farthest north/south/west/east using latitude/longitude data
			var northPerson = persons.MaxBy(x => x.Latitude);
			var southPerson = persons.MinBy(x => x.Latitude);
			var westPerson = persons.MinBy(x => x.Longitude);
			var eastPerson = persons.MaxBy(x => x.Longitude);
			WriteLine(northPerson.Name+" "+northPerson.Latitude);
			WriteLine(southPerson.Name+" "+southPerson.Latitude);
			WriteLine(westPerson.Name+" "+westPerson.Latitude);
			WriteLine(eastPerson.Name+" "+eastPerson.Latitude);

			//find max and min distance between 2 persons
			double maxDistance = 0;
			foreach(var person1 in persons)
			{
				foreach(var person2 in persons.Where(x => x.Guid != person1.Guid))
				{
					double distance = Distance(person1,person2);
					if (distance > maxDistance) 
					{
						WriteLine(person1.Longitude +";" +person1.Latitude);
						WriteLine(person2.Longitude +";" +person2.Latitude);
						maxDistance = distance;
					}
				}
			}
			WriteLine(maxDistance);

			//find 2 persons whos ‘about’ have the most same words


			//find persons with same friends (compare by friend’s name)

		}
	}
}
