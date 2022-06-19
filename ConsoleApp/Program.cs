using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

var randomArray = new[] { (1, true), (2, false) };
var binaryFormatter = new BinaryFormatter();
using var file = File.OpenWrite("text.bin");
binaryFormatter.Serialize(file, randomArray);