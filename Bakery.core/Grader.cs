using System;
using System.Collections.Generic;
using System.Linq;

namespace Bakery.Core;

public static class Grader
{
    public static string Grade(int score)
    {
        return score switch
        {
            >= 90 => "A",
            >= 80 => "B",
            >= 70 => "C",
            >= 60 => "D",
            _ => "F"
        };
    }

    public static string Grade(decimal score)
    {
        return Grade((int)Math.Round(score));
    }

    public static double Average(IEnumerable<int> scores)
    {
        var values = scores.ToList();

        return values.Count == 0 ? 0 : values.Average();
    }

    public static decimal Average(IEnumerable<decimal> scores)
    {
        var values = scores.ToList();

        return values.Count == 0 ? 0 : values.Average();
    }
}