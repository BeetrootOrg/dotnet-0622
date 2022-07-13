using ConsoleApp;

using static System.Console;

WriteLine("Hello world".CountWords());
WriteLine(StringExtensions.CountWords("Hello world"));
WriteLine("hello world hello".CountWords("hello"));
WriteLine("world".CountWords("hello"));
WriteLine("world".CountWords("world"));
