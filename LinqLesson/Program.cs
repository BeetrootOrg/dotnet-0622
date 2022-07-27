using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace LinqLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            var persons = JsonConvert.DeserializeObject<IEnumerable<Person>>(File.ReadAllText("data.json"));

            //1: count males
            var males = persons.Count(persons => persons.Gender == Gender.Male);
            System.Console.WriteLine(males);

            //2: count females 
            var females = persons.Count(persons => persons.Gender == Gender.Female);
            System.Console.WriteLine(females);

            //3. youngest person
            var youngestAge = persons.Min(persons => persons.Age);
            var youngestPerson = persons.MinBy(persons => persons.Age);
            System.Console.WriteLine(youngestPerson);

            //4: oldest person
            var oldestAge = persons.MaxBy(x => x.Age);
            System.Console.WriteLine($"Oldest Person is {oldestAge}");

            //5: all youngest
            var youngestPersons = persons.Where(x => x.Age == youngestAge);
            System.Console.WriteLine($"There are {youngestPersons.Count()} people");

            //6: average age
            var averageAge = persons.Average(x => x.Age);
            System.Console.WriteLine($"Average age is {averageAge}");

            //7.1. count people with same eye color
            //find all and then filter
            var eyesColors = persons.Select(x => x.EyeColor);//we get all eye colors
            var uniqueEyesColors = eyesColors.Distinct(); // get only unique eyes
            foreach (var eyeColor in uniqueEyesColors)
            {
                var countSameEyeColor = persons.Count(x => x.EyeColor == eyeColor);
                System.Console.WriteLine($"{eyeColor} has {countSameEyeColor} people");
            }

            //7.2 using GroupBy
            var eyeColorGroup = persons.GroupBy(x => x.EyeColor);
            foreach (var item in eyeColorGroup)
            {
                System.Console.WriteLine($"{item.Key} has {item.Count()} people");
            }

            //Homework

            //1: find out who is located farthest north/south/west/east using latitude/longitude data
            //North
            var northestPerson = persons.MaxBy(x => x.Longitude);
            System.Console.WriteLine($"Northest Living person {northestPerson.Name}");

            //South
            var southestPerson = persons.MinBy(x => x.Longitude);
            System.Console.WriteLine($"Southest Living person {southestPerson.Name}");

            //East
            var eastestPerson = persons.MaxBy(x => x.Latitude);
            System.Console.WriteLine($"Eastest Living person {eastestPerson.Name}");

            //West
            var westestPerson = persons.MinBy(x => x.Latitude);
            System.Console.WriteLine($"Westest Living person {westestPerson.Name}");


            //2:find max and min distance between 2 persons
            static double ToRadians(double angle)
            {
                return angle * System.Math.PI / 180;
            }

            static double CalculateDistance(Person personA, Person personB)
            {
                const double EarthRadius = 6371;

                double deltaLong = ToRadians(personB.Longitude) - ToRadians(personA.Longitude);
                double deltaLat = ToRadians(personB.Latitude) - ToRadians(personA.Latitude);

                //double sinY1 = System.Math.Sin(ToRadians(personA.Latitude));
                //double sinY2 = System.Math.Sin(ToRadians(personB.Latitude));
                double cosY1 = System.Math.Cos(ToRadians(personA.Latitude));
                double cosY2 = System.Math.Cos(ToRadians(personB.Latitude));

                //double cosDelta = System.Math.Cos(ToRadians(delta));

                double sinDeltaLat = System.Math.Sin(deltaLat / 2) * System.Math.Sin(deltaLat / 2);
                double sinDeltaLong = System.Math.Sin(deltaLong / 2) * System.Math.Sin(deltaLong / 2);
                double a = sinDeltaLat + cosY1 * cosY2 * sinDeltaLong;
                double x = System.Math.Sqrt(a);
                double c = 2 * System.Math.Asin(x);
                return (EarthRadius * c);

            }

            static (double, Person, Person) InitializeTuple(double value = 0, Person person1 = null, Person person2 = null)
            {
                (double, Person, Person) tuple;

                tuple.Item1 = value;
                tuple.Item2 = person1;
                tuple.Item3 = person2;

                return tuple;
            }

            var maxDistance = InitializeTuple();
            var minDistance = InitializeTuple();
            minDistance.Item1 = 6372795; // Earth Radius
            foreach (var personA in persons)
            {
                foreach (var personB in persons)
                {
                    if (personA.Name == personB.Name) continue;
                    var calculatedDistance = CalculateDistance(personA, personB);
                    if (maxDistance.Item1 < calculatedDistance)
                    {
                        maxDistance = InitializeTuple(calculatedDistance, personA, personB);
                    }
                    if (minDistance.Item1 > calculatedDistance)
                    {
                        minDistance = InitializeTuple(calculatedDistance, personA, personB);
                    }
                }
            }

            System.Console.WriteLine($"Max distance = {maxDistance.Item1} betwen {maxDistance.Item2.Name} and {maxDistance.Item3.Name}");
            System.Console.WriteLine($"Min distance = {minDistance.Item1} betwen {minDistance.Item2.Name} and {minDistance.Item3.Name}");

            //3: find 2 persons whos ‘about’ have the most same words
            
			List<(Person, string, int)> wordCountDictionary = new List<(Person, string, int)>();
            var wordList = persons.Select(x => x.About.Split().ToList());
			
			int counter = 0;



        }


    }
}
