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

            //1 - find out who is located farthest north/south/west/east using latitude/longitude data
            var north = persons.MaxBy(person => person.Latitude);
            WriteLine($"The person who is to the north: {north}");
            var south = persons.MinBy(person => person.Latitude);
            WriteLine($"The person who is to the south: {south}");
            var east = persons.MaxBy(person => person.Longitude);
            WriteLine($"The person who is to the east: {east}");
            var west = persons.MinBy(person => person.Longitude);
            WriteLine($"The person who is to the west: {west}");

            //2 - find max and min distance between 2 persons
            double maxDistance = 0;
            double minDistance = 0;
            string personOneMaxDistance = null, personTwoMaxDistance = null,
                personOneMinDistance = null, personTwoMinDistance = null;
            foreach (var item1 in persons)
            {
                var personOneLatitude = item1.Latitude;
                var personOneLongitude = item1.Longitude;
                foreach (var item2 in persons)
                {
                    var personoTwoLatitude = item2.Latitude;
                    var personTwoLongitude = item2.Longitude;
                    var distance = Math.Sqrt(Math.Pow((personoTwoLatitude - personOneLatitude), 2) +
                        Math.Pow((personTwoLongitude - personOneLongitude), 2));
                    if (item1.Name != item2.Name)
                    {
                        if (maxDistance < distance)
                        {
                            maxDistance = distance;
                            personOneMaxDistance = item1.Name;
                            personTwoMaxDistance = item2.Name;
                        }
                        if (minDistance == 0 || minDistance > distance)
                        {
                            minDistance = distance;
                            personOneMinDistance = item1.Name;
                            personTwoMinDistance = item2.Name;
                        }
                    }
                }
            }
            WriteLine($"Max distance {maxDistance} between {personOneMaxDistance} and {personTwoMaxDistance}");
            WriteLine($"Min distance {minDistance} between {personOneMinDistance} and {personTwoMinDistance}");

            //3 - find 2 persons whos ‘about’ have the most same words
            Person personFirstWords = new Person();
            Person personSecondWords = new Person();
            string firstPerson = null, secondPerson = null,
                aboutFirstPerson, aboutSecondPerson;
            int count = 0;
            foreach (var item1 in persons)
            {
                aboutFirstPerson = item1.About;

                foreach (var item2 in persons)
                {
                    if (item1.Name != item2.Name)
                    {
                        aboutSecondPerson = item2.About;
                        int sameCount = 0;
                        foreach (var item in aboutSecondPerson.Split(new char[] { ' ', '.', ',' },
                            StringSplitOptions.RemoveEmptyEntries))
                            if (aboutFirstPerson.Contains(item)) ++sameCount;
                        if (sameCount > count)
                        {
                            count = sameCount;
                            firstPerson = item1.Name;
                            secondPerson = item2.Name;
                        }
                    }
                }
            }
            WriteLine($"Max same words {count} between {firstPerson} and {secondPerson}");

            //4 - find persons with same friends (compare by friend’s name)
            string person1 = null;
            string person2 = null;
            int friendCounter = 0;
            foreach (var item1 in persons)
            {
                foreach (var item2 in persons)
                {
                    if (item1.Name == item2.Name) continue;
                    int counter = 0;
                    foreach (var item in item2.Friends)
                    {
                        if (item1.Friends.Contains(item)) ++counter;
                    }
                    if (counter > friendCounter)
                    {
                        friendCounter = counter;
                        person1 = item1.Name;
                        person2 = item2.Name;
                    }
                }
            }
            WriteLine($"{person1} and {person2} have {friendCounter} same friends");
        }
    }
}
