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

            // 1. count males
            var males = persons.Count(person => person.Gender == Gender.Male);
            // WriteLine($"Males: {males}");

            // 2. count females
            var females = persons.Count(person => person.Gender == Gender.Female);
            // WriteLine($"Females: {females}");

            // 3. youngest person and his age
            var youngestAge = persons.Min(person => person.Age);
            var youngestPerson = persons.MinBy(person => person.Age);
            //WriteLine($"Youngest person is {youngestPerson}");

            // 4. oldest person and his age
            var oldestAge = persons.Max(person => person.Age);
            WriteLine($"Oldest age is {oldestAge}");
            var oldestPerson = persons.MaxBy(x => x.Age);
            WriteLine($"Oldest person is {oldestPerson}");

            // 5. all youngest - if we have many youngest persons
            var youngestPersons = persons.Where(x => x.Age == youngestAge);
            WriteLine($"There are {youngestPersons.Count()} people");

            // 6. average age from our collection
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

            /*
			finish all tasks from lesson using LinqExample.zip and do next:

			1) find out who is located farthest north/south/west/east using latitude/longitude data
			2) find max and min distance between 2 persons
			3) find 2 persons whos ‘about’ have the most same words
			4) find persons with same friends (compare by friend’s name) //Jeannie Waters

			1) знайти персону що найпівнічніша , найпівденніша, найзахідніша, найпівденніша по координатам
			2) знайти максимальну дистанцію між двома персонами по формулі і так само мінімальну
			3) схоже робили на уроці - знайти персони у яких єбаут має найбільше схожих слів
			запустити цикл перебрати для кожної персони усі інші персони і порівняти чи є ц них спільні друзі.. 
			якщо є то такі персони записати в новий список ( френдліст список людей зі спільними друзями)

			потім по списку френдліст пройтися 

			4) знайти персон у кого є однакові друзі (порівнювати за іменем друга)
			*/

            System.Console.Clear();
            System.Console.WriteLine();
            // HOMEWORK 
            System.Console.WriteLine("1- find out who is located farthest north/south/west/east using latitude/longitude data");
            //  1.1 farthest north person
            var nordestPosition = persons.Min(person => person.Latitude);
            var nordestPerson = persons.MinBy(person => person.Latitude);
            WriteLine("farthest north is " + nordestPosition + " for person = " + nordestPerson.Name);
            //  1.2 farthest south person
            var southPosition = persons.Max(person => person.Latitude);
            var southPerson = persons.MaxBy(person => person.Latitude);
            WriteLine("farthest south Position is " + southPosition + "  for person = " + southPerson.Name);
            //1.3 farthest west person
            var westPosition = persons.Min(person => person.Longitude);
            var westPerson = persons.MinBy(person => person.Longitude);
            WriteLine("farthest west is " + westPosition + " for person = " + westPerson.Name);
            //  1.4 farthest east  person
            var eastPosition = persons.Max(person => person.Longitude);
            var eastPerson = persons.MaxBy(person => person.Longitude);
            WriteLine("farthest east Position is " + eastPosition + "  for person = " + eastPerson.Name);

            //2.0 find max and min  distanse beetwen 2 persons
            System.Console.WriteLine("2- find max and min  distanse beetwen 2 persons");
            double totalMaxDistance = 0, totalMinDistance = 0;
            string person1Max = "", person2Max = "", person1Min = "", person2Min = "";
            double lnp1, ltp1, lnp2, ltp2;
            double currentdistance;

            foreach (var person in persons)
            {
                ltp1 = person.Latitude;
                lnp1 = person.Longitude;

                foreach (var person2 in persons)
                {
                    if (person.Name != person2.Name)
                    {
                        double P1, P2;
                        ltp2 = person2.Latitude;
                        lnp2 = person2.Longitude;
                        P1 = (ltp2 - ltp1) * 2;
                        P2 = (lnp2 - lnp1) * 2;

                        currentdistance = Math.Sqrt(P1 + P2);
                        if (totalMaxDistance < currentdistance)
                        {
                            totalMaxDistance = currentdistance;
                            person1Max = person.Name;
                            person2Max = person2.Name;
                        }
                        if (totalMinDistance > currentdistance || totalMinDistance == 0)
                        {
                            totalMinDistance = currentdistance;
                            person1Min = person.Name;
                            person2Min = person2.Name;
                        }
                    }
                }
            }
            System.Console.WriteLine("MaxDistans = " + totalMaxDistance + " between person " + person1Max + " and " + person2Max);
            System.Console.WriteLine("MinDistans = " + totalMinDistance + " between person " + person1Min + " and " + person2Min);

            //3.0 find 2 persons whos ‘about’ have the most same words
            System.Console.WriteLine("2- find max and min  distanse beetwen 2 persons");
        }
    }
}
