using System;
using System.Collections.Generic;
using System.Linq;

namespace Bakery.Core;

public class OrderBook
{
    private readonly List<Order> orders = new();

    public IReadOnlyList<Order> Orders => orders;

    public void Add(Order order)
    {
        if (order == null)
            throw new ArgumentNullException(nameof(order));

        orders.Add(order);
    }

    public decimal TotalSales()
    {
        return orders.Sum(o => o.Total);
    }

    public int TotalItems()
    {
        return orders.Sum(o => o.Quantity);
    }

    public Order? Find(string item)
    {
        return orders.FirstOrDefault(
            o => string.Equals(o.Item, item, StringComparison.OrdinalIgnoreCase));
    }

    public IEnumerable<Order> GetOrders()
    {
        return orders;
    }
}