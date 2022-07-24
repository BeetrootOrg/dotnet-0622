using Newtonsoft.Json;
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

            /*
			finish all tasks from lesson using LinqExample.zip and do next:

			1) find out who is located farthest north/south/west/east using latitude/longitude data
			find max and min distance between 2 persons
			find 2 persons whos ‘about’ have the most same words
			find persons with same friends (compare by friend’s name)

			1) знайти персону що найпівнічніша , найпівденніша, найзахідніша, найпівденніша по координатам
			2) знайти максимальну дистанцію між двома персонами по формулі
			3) схоже робили на уроці - знайти персони у яких єбаут має найбільше схожих слів
			4) знайти персон у кого є однакові друзі (порівнювати за іменем друга)



			*/

        }
    }
}
