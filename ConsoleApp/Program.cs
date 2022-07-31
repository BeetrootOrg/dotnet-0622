
using System.Linq;
using System.Text;

using ConsoleApp;

using Newtonsoft.Json.Linq;

class Program
{
    static void Main(string[] args)
    {
        
        var url = "https://api.opensensemap.org/boxes/5dbcb7cec8eb60001bdcb18b?format=json";
        var request = new SenseBoxResponse(url);

        Console.WriteLine("Hello! it's SenseBoxGrabber!");
        Console.WriteLine();
        Console.WriteLine("Pulling request...");
        var resultrequest = request.RunAsync();
        while (true)
        {
            if (resultrequest.IsCompletedSuccessfully)
            {
                Console.WriteLine("Done!");
                Console.WriteLine();

                var response = request.Response;

                var json = JObject.Parse(response);

                Console.WriteLine($"Station name {json["name"]}.");
                Console.WriteLine($"Last data was at {json["lastMeasurementAt"]}.");
                Console.WriteLine($"Station position {json["exposure"]}.");
                var location = new StringBuilder();
                foreach (var item in json["grouptag"])
                {
                    location.Append(item);
                }
                Console.WriteLine("Location: " + location);
                Console.WriteLine();
                Console.WriteLine();

                foreach (var sensor in json["sensors"])
                {
                    Console.WriteLine(sensor["title"] + " sensor.");
                    Console.WriteLine("Sensortype is " + sensor["sensorType"] + ".");
                    Console.WriteLine("Value is " + sensor["lastMeasurement"]["value"] + " " + sensor["unit"] + ".");
                    Console.WriteLine();

                }
                break;
            }
        }
        
            
    }
}
