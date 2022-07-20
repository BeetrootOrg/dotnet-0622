using Newtonsoft.Json;
using static System.Console;
using System.Collections.Generic;
using System.IO;

namespace LinqLesson
{
	class Program
	{
		static void Main(string[] args)
		{
			var persons = JsonConvert.DeserializeObject<IEnumerable<Person>>(File.ReadAllText("data.json"));
		}
	}
}