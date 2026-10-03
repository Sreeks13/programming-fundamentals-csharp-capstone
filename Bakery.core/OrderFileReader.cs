using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace Bakery.Core;

public static class OrderFileReader
{
    public static List<Order> Read(string filePath)
    {
        var result = new List<Order>();

        foreach (var line in File.ReadLines(filePath))
        {
            if (string.IsNullOrWhiteSpace(line))
                continue;

            var parts = line.Split(
                ',',
                StringSplitOptions.TrimEntries |
                StringSplitOptions.RemoveEmptyEntries);

            if (parts.Length < 3)
                continue;

            var item = parts[0];

            if (!int.TryParse(parts[1], out var quantity))
                continue;

            if (!decimal.TryParse(
                    parts[2],
                    NumberStyles.Number,
                    CultureInfo.InvariantCulture,
                    out var price))
                continue;

            result.Add(new Order(item, quantity, price));
        }

        return result;
    }
}