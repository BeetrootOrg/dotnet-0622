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
        public static double ToRadians(double angleIn10thofaDegree)
        {
            return (angleIn10thofaDegree * Math.PI) / 180;
        }
        public static (Person, Person, double) CalculateDistance(Person person1, Person person2)
        {
            double r = 6371;

            double lon1 = ToRadians(person1.Longitude);
            double lon2 = ToRadians(person2.Longitude);
            double lat1 = ToRadians(person1.Latitude);
            double lat2 = ToRadians(person2.Latitude);

            double dlon = lon2 - lon1;
            double dlat = lat2 - lat1;
            double a = Math.Pow(Math.Sin(dlat / 2), 2) +
                       Math.Cos(lat1) * Math.Cos(lat2) *
                       Math.Pow(Math.Sin(dlon / 2), 2);
            double c = 2 * Math.Asin(Math.Sqrt(a));

            return (person1, person2, (c * r));
        }
        static private string ShowTupple((Person, Person, double) distanceTupple)
        {
            return $"distance between {distanceTupple.Item1.Name} and {distanceTupple.Item2.Name} is {distanceTupple.Item3}";
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

            // 8. common tags
            var allTagsSelected = persons.Select(x => x.Tags);
            var allTags = persons.SelectMany(x => x.Tags);
            var tagsGroups = allTags.GroupBy(x => x);
            var mainTag = tagsGroups.MaxBy(x => x.Count()).Key;

            var personsWithSameTag = persons.Where(x => x.Tags.Contains(mainTag)).Count();
            WriteLine($"Persons with same tag '{mainTag}' are {personsWithSameTag}");

            WriteLine("HOMEWORK");
            // 9. the southernmost person 
            var southernmosttPerson = persons.MinBy(x => x.Latitude);
            WriteLine($"The southernmost person is {southernmosttPerson}");

            // 10. the northernmost person
            var northernmostPerson = persons.MaxBy(x => x.Latitude);
            WriteLine($"The northernmost person is {northernmostPerson}");

            // 11. the westernmost person
            var westernmostPerson = persons.MinBy(x => x.Longitude);
            WriteLine($"The westernmost person is {westernmostPerson}");

            // 12. the easternmost person
            var esternmosttPerson = persons.MaxBy(x => x.Longitude);
            WriteLine($"The easternmost person is {esternmosttPerson}");

            // 9. max distance between 2 persons 
            var personsList = persons.ToList();
            List<(Person, Person, double)> DistanceBetweenPersons = new List<(Person, Person, double)>();
            for (int i = 0; i < personsList.Count - 1; i++)
            {
                for (int j = i + 1; j < personsList.Count; j++)
                {
                    var temp = CalculateDistance(personsList[i], personsList[j]);
                    DistanceBetweenPersons.Add(temp);
                }
            }
            var maxDistanceBetweenTwoPersons = DistanceBetweenPersons.MaxBy(x => x.Item3);
            WriteLine("The maximum " + ShowTupple(maxDistanceBetweenTwoPersons));

            var minDistanceBetweenTwoPersons = DistanceBetweenPersons.MinBy(x => x.Item3);
            WriteLine("The minimum " + ShowTupple(minDistanceBetweenTwoPersons));

            // 10. persons with the most common words in "about"
            var grouppedByAbouts = persons.GroupBy(x => x.About.Split(new char[] { ' ', '.', ',' }, StringSplitOptions.RemoveEmptyEntries));
            var aboutsList = grouppedByAbouts.ToList();
            int counter = 0;
            string person1 = "";
            string person2 = "";
            for (int i = 0; i < aboutsList.Count - 1; i++)
            {
                for (int j = i + 1; j < aboutsList.Count; j++)
                {
                    var numberOfWordsInCommon = (aboutsList[j].Key.Intersect(aboutsList[i].Key).Count());
                    if (numberOfWordsInCommon > counter)
                    {
                        counter = numberOfWordsInCommon;
                        var temp = aboutsList.SelectMany(x => x);
                        var tempList = temp.ToList();
                        person1 = tempList[i].Name;
                        person2 = tempList[j].Name;
                    }
                }
            }
            WriteLine($"{person1} and {person2} have {counter} common words in their About information");

            // 11. Persons with mutual friends

            var friendsGroups = persons.GroupBy(x => x.Friends);
            var friendsList = friendsGroups.ToList();
            bool hasMutualFriends = false;
            for (int i = 0; i < friendsList.Count - 1; i++)
            {
                for (int j = i + 1; j < friendsList.Count; j++)
                {
                    var mutualFriends = (friendsList[i].Key.Intersect(friendsList[j].Key).Count());

                    if (mutualFriends > 0)
                    {
                        hasMutualFriends = true;
                        var temp = friendsList.SelectMany(x => x);
                        var tempList = temp.ToList();
                        person1 = tempList[i].Name;
                        person2 = tempList[j].Name;
                        WriteLine($"{person1} and {person2} have {mutualFriends} number of same friends");
                    }
                }
            }
            if (!hasMutualFriends)
            {
                WriteLine("Nobody has mutual friends");
            }
        }
    }
}
