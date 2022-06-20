using System;
using System.Text;

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