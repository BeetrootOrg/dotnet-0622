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

            // 1. find out who is located farthest north/south/west/east using latitude/longitude data
            //north
			var maxNorth = persons.MaxBy( x => x.Latitude);
            WriteLine ($"The most North: {maxNorth.Name}");
			//south
			var maxSouth = persons.MinBy( x => x.Latitude);
            WriteLine ($"The most North South: {maxSouth.Name}");
			//west
            var maxEast = persons.MaxBy( x => x.Longitude);
            WriteLine ($"The most West South: {maxEast.Name}");
			//east
            var maxWest = persons.MinBy( x => x.Longitude);
            WriteLine ($"The most Wast South: {maxWest.Name}");



        }
    }
}
