using System;
using System.Collections.Generic;

namespace ConsoleApp;

static class MyExtensions
{
    private static IDictionary<string, bool> ToBooleans = new Dictionary<string, bool>
    {
        ["yes"] = true,
        ["1"] = true,
        ["y"] = true,
        ["true"] = true,

        ["no"] = false,
        ["0"] = false,
        ["n"] = false,
        ["false"] = false,
    };

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

    public static bool ToBool(this string str)
    {
        return ToBooleans.ContainsKey(str)
            ? ToBooleans[str]
            : throw new ArgumentOutOfRangeException(nameof(str));
    }

    public static byte CalculateAge(this DateTime birthDate)
    {
        var now = DateTime.Now;
        if (birthDate > now)
        {
            throw new ArgumentException($"Birth date should be in the past");
        }

        var diff = now - birthDate;
        return (byte)(new DateTime().Add(diff).Year - 1);
    }

    public static bool IsWeekend(this DateTime dateTime)
    {
        return dateTime.DayOfWeek switch
        {
            DayOfWeek.Sunday => true,
            DayOfWeek.Saturday => true,
            _ => false
        };
    }

    public static bool IsWorkday(this DateTime dateTime)
    {
        return !IsWeekend(dateTime);
    }

    public static DateOnly NextWorkingDay(this DateTime dateTime)
    {
        var nextDay = dateTime.Date;
        var oneDay = TimeSpan.FromDays(1);

        do
        {
            nextDay += oneDay;
        } while (nextDay.IsWeekend());

        return DateOnly.FromDateTime(nextDay);
    }
}