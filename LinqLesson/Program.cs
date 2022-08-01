using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;

using static System.Math;
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

            // 9.farthest located person
            var farthestNorth = persons.MaxBy(x => x.Latitude);
            var farthestSouth = persons.MinBy(x => x.Latitude);
            var farthestEast = persons.MaxBy(x => x.Longitude);
            var farthestWest = persons.MinBy(x => x.Longitude);
            WriteLine($"Person located farthest north is {farthestNorth.Name}");
            WriteLine($"Person located farthest south is {farthestSouth.Name}");
            WriteLine($"Person located farthest east is {farthestEast.Name}");
            WriteLine($"Person located farthest west is {farthestWest.Name}");

            //10. max/min distance between persons
            var distance = new List<Tuple<double, Person, Person>>();

            for (int i = 0; i < persons.Count(); i++)
            {
                var person1 = persons.ElementAt(i);

                for (int j = i + 1; j < persons.Count(); j++)
                {
                    var person2 = persons.ElementAt(j);
                    var distanceBetween = HaversineDistance(
                        person1.Latitude, person1.Longitude,
                        person2.Latitude, person2.Longitude
                    );
                    distance.Add(new Tuple<double, Person, Person>(distanceBetween, person1, person2));
                }
            }

            var maxDistance = distance.MaxBy(x => x.Item1);
            WriteLine($"Maximum distance is {(int)maxDistance.Item1} km. It is between {maxDistance.Item2.Name} and {maxDistance.Item3.Name}");

            var minDistance = distance.MinBy(x => x.Item1);
            WriteLine($"Minimum distance is {(int)minDistance.Item1} km. It is between {minDistance.Item2.Name} and {minDistance.Item3.Name}");

            //11. persons whose 'about' have the most same words

            Person sameWordsPerson1 = new Person();
            Person sameWordsPerson2 = new Person();

            int wordCount = 0;
            char[] separators = new char[] { ' ', '.' };

            for (int i = 0; i < persons.Count(); i++)
            {
                var person1 = persons.ElementAt(i);
                var person1Words = person1.About.Split(separators, StringSplitOptions.RemoveEmptyEntries);

                for (int j = i + 1; j < persons.Count(); j++)
                {
                    var person2 = persons.ElementAt(j);

                    var person2Words = person2.About.Split(separators, StringSplitOptions.RemoveEmptyEntries);

                    IEnumerable<string> allSameWords = Enumerable.Empty<string>();

                    foreach (var word in person1Words)
                    {
                        allSameWords = person2Words.Where(w => w == word).Concat(allSameWords);

                    }

                    if (wordCount < allSameWords.Count())
                    {
                        wordCount = allSameWords.Count();
                        sameWordsPerson1 = person1;
                        sameWordsPerson2 = person2;
                    }

                }
            }
            System.Console.WriteLine($"The most same 'about' words ({wordCount}) have persons : {sameWordsPerson1.Name} and {sameWordsPerson2.Name}");

            //12. persons with same friends


            for (int i = 0; i < persons.Count(); i++)
            {
                var person1 = persons.ElementAt(i);

                for (int j = i + 1; j < persons.Count(); j++)
                {
                    var person2 = persons.ElementAt(j);
                    List<string> sameFriends = new List<string>();

                    foreach (var friend in person1.Friends)
                    {
                        var person2Friends = person2.Friends.Select(f => f.Name);
                        //System.Console.WriteLine(sameFriends1.Count());
                        if (person2Friends.Contains(friend.Name))
                        {
                            sameFriends.Add(friend.Name);
                        }
                    }
                    if (sameFriends.Count() > 0)
                    {

                        System.Console.WriteLine($"{person1.Name} and {person2.Name} have {sameFriends.Count()} common friends");

                    }
                }
            }
        }


        public static double HaversineDistance(double lat1, double long1, double lat2, double long2)
        {
            var pos1 = new LatLng(lat1, long1);
            var pos2 = new LatLng(lat2, long2);
            double R = 6371;
            var lat = (pos2.Latitude - pos1.Latitude).ToRadians();
            var lng = (pos2.Longitude - pos1.Longitude).ToRadians();
            var h1 = Math.Sin(lat / 2) * Math.Sin(lat / 2) +
                          Math.Cos(pos1.Latitude.ToRadians()) * Math.Cos(pos2.Latitude.ToRadians()) *
                          Math.Sin(lng / 2) * Math.Sin(lng / 2);
            var h2 = 2 * Math.Asin(Math.Min(1, Math.Sqrt(h1)));
            return R * h2;
        }

        public enum DistanceUnit { Miles, Kilometers };

    }
}









