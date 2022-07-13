using System;
using System.Collections.Generic;

using ConsoleApp;

using static System.Console;

internal class Program
{
    private static void Main(string[] args)
    {
        WriteLine("Hello world".CountWords());
        // NullReference below
        // WriteLine(StringExtensions.CountWords(null));

        // string str = null;
        // str.CountWords();

        WriteLine("Hello world".CountWords());
        WriteLine("hello world hello".CountWords("hello"));
        WriteLine("world".CountWords("hello"));
        WriteLine("world".CountWords("world"));

        Show(new[] { 1, 2, 3, 4 }.ChunkBy(2));
        Show(new[] { 1, 2, 3, 4, 5 }.ChunkBy(2));
        Show(new[] { 1, 2, 3, 4, 5 }.ChunkBy(3));
        Show(Array.Empty<int>().ChunkBy(3));

        WriteLine("yes".ToBool());
        WriteLine("no".ToBool());

        WriteLine(new DateTime(1996, 07, 11).CalculateAge());
        WriteLine(new DateTime(1994, 04, 19).CalculateAge());
        WriteLine(new DateTime(1994, 07, 13).CalculateAge());

        WriteLine(new DateTime(2022, 07, 16).IsWeekend());
        WriteLine(new DateTime(2022, 07, 17).IsWeekend());
        WriteLine(new DateTime(2022, 07, 18).IsWeekend());
        WriteLine(new DateTime(2022, 07, 19).IsWeekend());
        WriteLine(new DateTime(2022, 07, 20).IsWeekend());
        WriteLine(new DateTime(2022, 07, 21).IsWeekend());
        WriteLine(new DateTime(2022, 07, 22).IsWeekend());

        WriteLine(new DateTime(2022, 07, 13).NextWorkingDay());
        WriteLine(new DateTime(2022, 07, 15).NextWorkingDay());
        WriteLine(new DateTime(2022, 07, 16).NextWorkingDay());
        WriteLine(new DateTime(2022, 07, 17).NextWorkingDay());

        Show(new[]
        {
            new
            {
                a = 1,
                b = 2
            },
            new
            {
                a = 1,
                b = 3
            },
            new
            {
                a = 2,
                b = 4
            }
        }.GroupBy(item => item.a));

        Show(new[]
        {
            new
            {
                a = 1,
                b = 2
            },
            new
            {
                a = 1,
                b = 3
            },
            new
            {
                a = 2,
                b = 4
            }
        }.GroupBy(item => item.b));
    }

    private static void Show<T>(IEnumerable<T> collection)
    {
        WriteLine(string.Join(", ", collection));
    }

    private static void Show<T>(IEnumerable<IEnumerable<T>> collection)
    {
        foreach (var item in collection)
        {
            Show(item);
        }
    }

    private static void Show<TKey, TValue>(IEnumerable<KeyValuePair<TKey, ICollection<TValue>>> collection)
    {
        foreach (var (key, value) in collection)
        {
            WriteLine($"[{key}: {string.Join(", ", value)}]");
        }
    }
}