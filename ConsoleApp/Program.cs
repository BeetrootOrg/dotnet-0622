using System;
using System.Text;
using System.Text.RegularExpressions;

void WriteArray(byte[] arr)
{
    Console.WriteLine($"Length: {arr.Length}");
    Console.WriteLine(string.Join(", ", arr));
}

var text = @"Lorem ipsum dolor sit amet consectetur adipisicing elit. 
Impedit iste nihil, soluta illum mollitia excepturi voluptatum officiis dignissimos 
libero dicta ut atque aut dolore alias molestiae adipisci debitis. 
Voluptatum repellendus ipsam cumque fugit quisquam accusantium laborum delectus, 
unde ullam nesciunt. Iure aut cumque, illum dicta accusamus atque ipsum et provident.";

var bytes = Encoding.UTF8.GetBytes(text);
WriteArray(bytes);

var result = Encoding.UTF8.GetString(bytes);
Console.WriteLine(result);

var regex = new Regex(@"^[-]*\d+$");
var strings = new[]
{
    "",
    "-",
    "1",
    "123",
    "000",
    "abc",
    "-1",
    "---1",
    "12a"
};

foreach (var item in strings)
{
    Console.WriteLine($"{item}: {regex.IsMatch(item)}");
}