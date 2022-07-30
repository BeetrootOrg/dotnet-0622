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

            // 1. find out who is located farthest north/south/west/east using latitude/longitude data
            //north
            var maxNorth = persons.MaxBy(x => x.Latitude);
            WriteLine($"The most North: {maxNorth.Name}");
            //south
            var maxSouth = persons.MinBy(x => x.Latitude);
            WriteLine($"The most North South: {maxSouth.Name}");
            //west
            var maxEast = persons.MaxBy(x => x.Longitude);
            WriteLine($"The most West South: {maxEast.Name}");
            //east
            var maxWest = persons.MinBy(x => x.Longitude);
            WriteLine($"The most Wast South: {maxWest.Name}");
            //2. 
            double maxDistance = 0, minDistance = 0;
            string person1Max = "", person2Max = "", person1Min = "", person2Min = "";
            double latitude1, longitude1, latitude2, longitude2, currentDistance;          
            foreach (var person in persons)
            {
                latitude1 = person.Latitude;
                longitude1 = person.Longitude;

                foreach (var person2 in persons)
                {
                    if (person.Name != person2.Name)
                    {
                        double tmp1, tmp2;
                        latitude2 = person2.Latitude;
                        longitude2 = person2.Longitude;
                        tmp1 = (latitude2 - latitude1) * 2;
                        tmp2 = (longitude2 - longitude1) * 2;
                        currentDistance = Math.Sqrt(tmp1 + tmp2);

                        if (maxDistance < currentDistance)
                        {
                            maxDistance = currentDistance;
                            person1Max = person.Name;
                            person2Max = person2.Name;
                        }
                        if (minDistance > currentDistance || minDistance == 0)
                        {
                            minDistance = currentDistance;
                            person1Min = person.Name;
                            person2Min = person2.Name;
                        }
                    }
                }
            }
            System.Console.WriteLine($"MaxDistans {maxDistance}  {person1Max}  &  {person2Max}");
            System.Console.WriteLine($"MinDistans {minDistance}  {person1Min}  &  {person2Min}");

            //3.



        }
    }
}
