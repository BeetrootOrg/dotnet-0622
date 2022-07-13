using System;
using System.Collections.Generic;

namespace ConsoleApp;

static class MyExtensions
{
    public static IEnumerable<IEnumerable<T>> ChunkBy<T>(this IEnumerable<T> collection, int size)
    {
        // 0. create instance of collection iterator
        // 1. create array[size]
        // 2. foreach in collection
        // 3. create subcollection from elements
        // 4. yield return array
        if (size <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(size));
        }

        var array = new T[size];
        var index = 0;

        foreach (var item in collection)
        {
            array[index++] = item;

            if (index >= size)
            {
                yield return array;
                array = new T[size];
                index = 0;
            }
        }

        if (index > 0)
        {
            Array.Resize(ref array, index);
            yield return array;
        }
    }
}