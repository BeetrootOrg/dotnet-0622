using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using LinqLesson;
using System;

namespace LinqLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = JsonConvert.DeserializeObject<List<Person>>(File.ReadAllText("data.json"));

            //1. Find out who is located farthest north/south/west/east using latitude/longitude data
            Person farthestNorthPerson = persons.MaxBy(x => x.Latitude);
            //System.Console.WriteLine(farthestNorthPerson);
            Person farthestSouthPerson = persons.MinBy(x => x.Latitude);
            //System.Console.WriteLine(farthestSouthPerson);
            Person farthestWestPerson = persons.MinBy(x => x.Longitude);
            //System.Console.WriteLine(farthestWestPerson);
            Person farthestEastPerson = persons.MaxBy(x => x.Longitude);
            //System.Console.WriteLine(farthestEastPerson);

            //2. Find max and min distance between 2 persons
            List<DistanceBetweenPersons> allDistances = new List<DistanceBetweenPersons>();
            for (int i = 0; i < persons.Count - 1; i++)
            {
                for (int j = i + 1; j < persons.Count; j++)
                {
                    allDistances.Add(distance(persons[i], persons[j]));
                }
            }
			DistanceBetweenPersons minDist = allDistances.MinBy(x => x.DistacneBetween);
			DistanceBetweenPersons maxDist = allDistances.MaxBy(x => x.DistacneBetween);
			System.Console.WriteLine(minDist);
			System.Console.WriteLine(maxDist);

        }
        static double toRadians(
           double angleIn10thofaDegree)
        {
            return (angleIn10thofaDegree * Math.PI) / 180;
        }
        static DistanceBetweenPersons distance(Person firstPerson, Person secondPerson)
        {
            double lon1 = toRadians(firstPerson.Longitude);
            double lon2 = toRadians(secondPerson.Longitude);
            double lat1 = toRadians(firstPerson.Latitude);
            double lat2 = toRadians(firstPerson.Latitude);

            double dlon = lon2 - lon1;
            double dlat = lat2 - lat1;
            double a = Math.Pow(Math.Sin(dlat / 2), 2) +
                       Math.Cos(lat1) * Math.Cos(lat2) *
                       Math.Pow(Math.Sin(dlon / 2), 2);

            double c = 2 * Math.Asin(Math.Sqrt(a));

            double r = 6371;

            double result = c * r;
            return new DistanceBetweenPersons(firstPerson, secondPerson, result);
        }
    }
}

