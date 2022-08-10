using Newtonsoft.Json;
using System;
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
			var personsList = persons.ToList();

			//find out who is located farthest north using latitude/longitude data
			var farthestNorth = persons.Max(n => n.Latitude);
			System.Console.WriteLine("Person who is located farthest north is " + personsList.Find(n => n.Latitude == farthestNorth).Name);

			//find out who is located farthest south using latitude/longitude data
			var farthestSouth = persons.Min(n => n.Latitude);
			System.Console.WriteLine("Person who is located farthest south is " + personsList.Find(n => n.Latitude == farthestSouth).Name);

			//find out who is located farthest west using latitude/longitude data
			var farthestWest = persons.Min(n => n.Longitude);
			System.Console.WriteLine("Person who is located farthest west is " + personsList.Find(n => n.Longitude == farthestWest).Name);

			//find out who is located farthest east using latitude/longitude data
			var farthestEast = persons.Max(n => n.Longitude);
			System.Console.WriteLine("Person who is located farthest east is " + personsList.Find(n => n.Longitude == farthestEast).Name + "\n");

			//find max and min distance between 2 persons
			var personsDistance = persons
				.Join(persons,
					person => true,
					person => true,
					(person1, person2) => new
					{
						Person1 = person1,
						Person2 = person2
					})
				.Where(x => !Object.ReferenceEquals(x.Person1, x.Person2))
				.Select(x =>
				{
					var person1 = x.Person1;
					var person2 = x.Person2;

					var pDistance = Distance(person1.Latitude,person2.Latitude,person1.Longitude,person2.Longitude);

					return new
					{
						Person1 = person1,
						Person2 = person2,
						PerDistance = pDistance
					};
				});
				System.Console.WriteLine($"Min distance between 2 persons are {personsDistance.Min(n => n.PerDistance)}");
				System.Console.WriteLine($"Max distance between 2 persons are {personsDistance.Max(n => n.PerDistance)}\n");

			//find persons with most common about words
			var personsWithMostCommonAboutWords = persons
				.Join(persons,
					person => true,
					person => true,
					(person1, person2) => new
					{
						Person1 = person1,
						Person2 = person2
					})
				.Where(x => !Object.ReferenceEquals(x.Person1, x.Person2))
				.Select(x =>
				{
					var person1 = x.Person1;
					var person2 = x.Person2;

					var about1 = person1.About.Split(' ');
					var about2 = person2.About.Split(' ');

					var intersection = about1.Intersect(about2).ToArray();

					return new
					{
						Person1 = person1,
						Person2 = person2,
						CommonWordsInAbout = intersection
					};
				})
				.MaxBy(x => x.CommonWordsInAbout.Length);
			WriteLine($"Max number of common words between two persons are {personsWithMostCommonAboutWords.CommonWordsInAbout.Length}\n");

			//find persons with same friends
			//I changed data.json file, so there are 1 common friend
			var personsWithCommonFriends = persons
				.Join(persons,
					person => true,
					person => true,
					(person1, person2) => new
					{
						Person1 = person1,
						Person2 = person2
					})
				.Where(x => !Object.ReferenceEquals(x.Person1, x.Person2))
				.Select(x =>
				{
					var person1 = x.Person1;
					var person2 = x.Person2;

					var friends1 = person1.Friends.Select(x => x.Name);
					var friends2 =person2.Friends.Select(x => x.Name);
					var commonFriends = friends1.Intersect(friends2);

					return new
					{
						Person1 = person1,
						Person2 = person2,
						CommonFriends = commonFriends
					};
				})
				.Where(x => x.CommonFriends.Count() >= 1);
			foreach (var item in personsWithCommonFriends)
			{
				System.Console.WriteLine($"Persons with same friends: {item.Person1.Name}");
			}
		}
		static double ToRadians(double angleIn10thOfADegree)
    	{
        	return (angleIn10thOfADegree * Math.PI) / 180;
    	}
    	static double Distance(double lat1, double lat2, double lon1, double lon2)
    	{
        	lon2 = ToRadians(lon2);
        	lon1 = ToRadians(lon1);
        	lat1 = ToRadians(lat1);
        	lat2 = ToRadians(lat2);
 
        	// Haversine formula
        	double dlon = lon2 - lon1;
        	double dlat = lat2 - lat1;
        	double a = Math.Pow(Math.Sin(dlat / 2), 2) +
                	Math.Cos(lat1) * Math.Cos(lat2) *
                	Math.Pow(Math.Sin(dlon / 2),2);
             
        	double c = 2 * Math.Asin(Math.Sqrt(a));
        	double r = 6371;
        	return (c * r);
    	}
	}
}
