using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using static System.Console;
using System.Text.RegularExpressions; 

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

			// 8. common tags
			var allTagsSelected = persons.Select(x => x.Tags);
			var allTags = persons.SelectMany(x => x.Tags);
			var tagsGroups = allTags.GroupBy(x => x);
			var mainTag = tagsGroups.MaxBy(x => x.Count()).Key;

			var personsWithSameTag = persons.Where(x => x.Tags.Contains(mainTag)).Count();
			WriteLine($"Persons with same tag '{mainTag}' are {personsWithSameTag}");

            // 9. Parts of World (max latitude)
            var maxNorth = persons.MaxBy( x => x.Latitude);
            WriteLine ($"Person who live the most North point is {maxNorth.Name}");
            
            var maxSouth = persons.MinBy( x => x.Latitude);
            WriteLine ($"Person who live the most South point is {maxSouth.Name}");

            var maxEast = persons.MaxBy( x => x.Longitude);
            WriteLine ($"Person who live the most South point is {maxEast.Name}");

            var maxWest = persons.MinBy( x => x.Longitude);
            WriteLine ($"Person who live the most South point is {maxWest.Name}");

            //10.
            //var distances = persons.GroupBy
            var distanses = new List<(double, Person, Person)>();

            for (int i = 0; i < persons.Count(); i++)
            {   
                for (int j = i + 1; j < persons.Count(); j++)
                {   
                    var person1 = persons.ElementAt(i);
                    var person2 = persons.ElementAt(j);
                    var distanceBtwPersons = Distance.CalcDistance(
                            person1.Latitude, person2.Latitude,
                            person1.Longitude, person2.Longitude);
                    distanses.Add((distanceBtwPersons, person1, person2));           
                }
            }

            var maxDistanseNote = distanses.MaxBy( x => x.Item1);
            WriteLine($"Maximum distance is {(int)maxDistanseNote.Item1} km, between "
                     + $"{maxDistanseNote.Item2.Name} and {maxDistanseNote.Item3.Name}");

            var minDistanseNote = distanses.MinBy( x => x.Item1);
            WriteLine($"Minimum distance is {(int)minDistanseNote.Item1} km, between "
                     + $"{minDistanseNote.Item2.Name} and {minDistanseNote.Item3.Name}");

            //11. find 2 persons whos ‘about’ have the most same words
            string[] AboutToArary(string about)
            {
                Regex rgx = new Regex("[^a-zA-Z0-9 -]");
                about = rgx.Replace(about, "");
                return about.Split(' ');
            }

            var similarWords = new List<(int, Person, Person)>();

            for (int i = 0; i < persons.Count(); i++)
            {   
                for (int j = i + 1; j < persons.Count(); j++)
                {   
                    var person1 = persons.ElementAt(i);
                    var person2 = persons.ElementAt(j);
                    int num = 0;
                    foreach (var word in AboutToArary(person1.About))
                    {
                       if (person2.About.Contains(word, System.StringComparison.OrdinalIgnoreCase))
                            num++; 
                    }

                    similarWords.Add((num, person1, person2));
                }
            }

            var similarAboutPersons = similarWords.MaxBy( x => x.Item1);
            WriteLine($"These persons have {similarAboutPersons.Item1} same words in theris about. "
                    + $"These persons are {similarAboutPersons.Item2.Name} and {similarAboutPersons.Item3.Name}");

            //11. Find persons with same friends (compare by friend’s name)

            var allFriends = persons.SelectMany(x => x.Friends);
            var spareFriends = allFriends.GroupBy( x => x.Name);
            var spareNames = spareFriends.Where( x => x.Count() > 1);
            var spareNamesCollection = spareNames.Select( x => x.Key);
            var uniqueCommonFriends = spareNamesCollection.Distinct();

            var FriendWithCommonFriends = new List<Person>();

             foreach (var commonFriend in uniqueCommonFriends)
             {
                 foreach (var person in persons)
                {
                    var personsFriend = person.Friends.Select( f => f.Name);
                    if(personsFriend.Contains(commonFriend))
                        FriendWithCommonFriends.Add(person);
                }
             }

            WriteLine($"These persons have common friends:");

            foreach (var person in FriendWithCommonFriends)
            {
                WriteLine($"{person.Name}");
            }
		}
	}

}