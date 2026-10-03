using System.Collections.Generic;
using System.Linq;

namespace Bakery.Core;

public static class Reports
{
    public static decimal TotalSales(IEnumerable<Order> orders)
    {
        return orders.Sum(o => o.Total);
    }

    public static int TotalItems(IEnumerable<Order> orders)
    {
        return orders.Sum(o => o.Quantity);
    }

    public static decimal AverageOrderValue(IEnumerable<Order> orders)
    {
        var list = orders.ToList();

        return list.Count == 0 ? 0 : list.Average(o => o.Total);
    }

    public static string StaffReport(IEnumerable<Staff> staff)
    {
        return string.Join(
            System.Environment.NewLine,
            staff.Select(s => $"{s.Name}: {s.Grade}"));
    }
}