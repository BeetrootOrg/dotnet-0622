﻿using System;
using System.Collections.Generic;

using ConsoleApp;

using static System.Console;

internal class Program
{
    private static void Main(string[] args)
    {
        WriteLine("Hello world".CountWords());
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
}