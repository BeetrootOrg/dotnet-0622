/// Convert to Radians.
/// </summary>
/// <param name="val">The value to convert to radians</param>
/// <returns>The value in radians</returns>
using System;
using static System.Math;

namespace LinqLesson;
public static class NumericExtensions
{
    public static double ToRadians(this double val)
    {
        return (Math.PI / 180) * val;
    }
}