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
		private static double MaxDistance(IEnumerable<Person> persons)
		{
			double maxDistance = 0;
			var personsCopy = persons;
			foreach(var person1 in persons)
			{
				personsCopy = personsCopy.Where(x => x.Guid != person1.Guid);
				foreach(var person2 in personsCopy)
				{
					double distance = Distance(person1,person2);
					if (distance > maxDistance) maxDistance = distance;
				}
			}
			return maxDistance;
		}

		private static double MinDistance(IEnumerable<Person> persons)
		{
			double minDistance = Math.PI*6371;
			var personsCopy = persons;
			foreach(var person1 in persons)
			{
				personsCopy = personsCopy.Where(x => x.Guid != person1.Guid);
				foreach(var person2 in personsCopy)
				{
					double distance = Distance(person1,person2);
					if (distance < minDistance) minDistance = distance;
				}
			}
			return minDistance;
		}
		private static double Distance(Person person1, Person person2)
		{
			double phi1 = person1.Latitude * Math.PI/180;
			double phi2 = person2.Latitude * Math.PI/180;
			double dphi = phi2 - phi1;
			double lDiff = (person2.Longitude-person1.Longitude)*Math.PI/180;
			double a = Math.Sin(dphi/2)*Math.Sin(dphi/2) + 
				Math.Cos(phi1)*Math.Cos(phi2)*Math.Sin(lDiff/2)*Math.Sin(lDiff/2);
			return 6371*2*Math.Atan2(Math.Sqrt(a), Math.Sqrt(1-a)); 
		}

		private static List<List<Person>> SameFriends(IEnumerable<Person> persons)
		{
			List<List<Person>> personsWithSameFriends = new List<List<Person>>();
			var personsCopy = persons;
			
			foreach(var person1 in persons)
			{
				List<Person> tempPersons = new List<Person>();
				tempPersons.Add(person1);
				personsCopy = personsCopy.Where(x => x.Guid != person1.Guid);

				foreach(var person2 in personsCopy)
				{
					if (IsSameFriend(person1, person2)) tempPersons.Add(person2); 
				}

				if (tempPersons.Count>1) personsWithSameFriends.Add(tempPersons);
			}

			return personsWithSameFriends;
		}

		private static bool IsSameFriend(Person person1, Person person2)
		{
			var friendList1 = person1.Friends.Select(x => x.Name).Where(x => x != person2.Name).ToList();
			var friendList2 = person2.Friends.Select(x => x.Name).Where(x => x != person1.Name).ToList();
			if (friendList1.Count != friendList2.Count) return false;
			foreach (var friend in friendList1)
				if (!friendList2.Contains(friend)) return false;
			return true;
		}

		private static Dictionary<string, List<Person>> AtLeastOneSameFriend(IEnumerable<Person> persons)
		{
			Dictionary<string, List<Person>> friendLists =  new Dictionary<string, List<Person>>();
			List<string> allFriends = new List<string>();
			foreach(var person in persons)
			{
				var friendList = person.Friends.Select(x => x.Name).ToList();
				foreach (var friend in friendList)
					if (!allFriends.Contains(friend)) allFriends.Add(friend);
			}
			
			foreach (var friend in allFriends)
			{
				List<Person> allPersonsWithCurrentFriend = new List<Person>();
				foreach (var person in persons)
					if (person.Friends.Select(x => x.Name).Contains(friend)) allPersonsWithCurrentFriend.Add(person);
				if (allPersonsWithCurrentFriend.Count>1) friendLists.Add(friend, allPersonsWithCurrentFriend);
			}

			return friendLists;
		}

		private static (Person, Person) MaxAboutSameWrods(IEnumerable<Person> persons)
		{
			int a = SameWordsCount(persons.First(), persons.Last());
			int maxSameWrodsCount = 0;
			Person personResult1 = new Person();
			Person personResult2 = new Person();
			var personsCopy = persons;

			foreach(var person1 in persons)
			{
				personsCopy = personsCopy.Where(x => x.Guid != person1.Guid);
				foreach(var person2 in personsCopy)
				{
					int sameWordsCount = SameWordsCount(person1, person2);
					if (sameWordsCount>maxSameWrodsCount)
					{
						personResult1 = person1;
						personResult2 = person2;
						maxSameWrodsCount = sameWordsCount;
					}
				}
			}

			return (personResult1, personResult2);
		}
		private static int SameWordsCount(Person person1, Person person2)
		{
			var about1 = (new string(person1.About.Where(x => 
				!char.IsPunctuation(x)).ToArray())).ToLower().Split(' ').Distinct();
			var about2 = (new string(person2.About.Where(x => 
				!char.IsPunctuation(x)).ToArray())).ToLower().Split(' ').Distinct();
			var sameWords = about1.Where(x => about2.Contains(x));
			return sameWords.Count();
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

			
			// 8. find out who is located farthest north/south/west/east 
			var northPerson = persons.MaxBy(x => x.Latitude);
			var southPerson = persons.MinBy(x => x.Latitude);
			var westPerson = persons.MinBy(x => x.Longitude);
			var eastPerson = persons.MaxBy(x => x.Longitude);
			WriteLine($"Most farthest north person is {northPerson.Name}");
			WriteLine($"Most farthest south person is {southPerson.Name}");
			WriteLine($"Most farthest west person is {westPerson.Name}");
			WriteLine($"Most farthest east person is {eastPerson.Name}");

			//8.1. find max and min distance between 2 persons
			WriteLine($"Max distance is: {MaxDistance(persons)}km");
			WriteLine($"Min distance is: {MinDistance(persons)}km");

			// 9. find 2 persons whos ‘about’ have the most same words
			var personsWithSimilarAbout = MaxAboutSameWrods(persons);
			WriteLine($"{personsWithSimilarAbout.Item1.Name} and {personsWithSimilarAbout.Item2.Name} have {SameWordsCount(personsWithSimilarAbout.Item1, personsWithSimilarAbout.Item2)} same words in 'about'");

			// 10. find persons with same friends
			var personsWithSameFriends = PersonsWithSameFriends(persons);
			if (personsWithSameFriends.Count == 0)
			{
				WriteLine("Persons with same friends not detected");
			}
			else
			{
				foreach (var item in personsWithSameFriends)
				{
					WriteLine($"{String.Join(", ", item)} have same friends");
				}
			}

			// 10.1 persons who have at least one same friend
			var personsWithSameFriend = AtLeastOneSameFriend(persons);
			if (personsWithSameFriend.Count == 0)
			{
				WriteLine("Persons with same friends not detected");
			}
			else
			{
				foreach (var item in personsWithSameFriend)
					WriteLine($"{String.Join(", ",personsWithSameFriend[item.Key].Select(x => x.Name))} have same friend {item.Key}");
			}
		}
	}
}
