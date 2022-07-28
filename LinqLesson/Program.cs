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
            
            //1 - find out who is located farthest north/south/west/east using latitude/longitude data
            var north = persons.MaxBy(person => person.Latitude);
            WriteLine($"The person who is to the north: {north}");
            var south = persons.MinBy(person => person.Latitude);
            WriteLine($"The person who is to the south: {south}");
            var east = persons.MaxBy(person => person.Longitude);
            WriteLine($"The person who is to the east: {east}");
            var west = persons.MinBy(person => person.Longitude);
            WriteLine($"The person who is to the west: {west}");
        }
    }
}
