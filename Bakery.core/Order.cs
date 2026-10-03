namespace Bakery.Core;

public class Order
{
    public string Item { get; set; }
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }

    public decimal Total => Quantity * UnitPrice;

    public Order(string item, int quantity, decimal unitPrice)
    {
        Item = item;
        Quantity = quantity;
        UnitPrice = unitPrice;
    }
}