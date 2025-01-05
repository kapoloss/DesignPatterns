using System;

namespace DesignPattern.Structural.FacadePattern.ExampleUsage;

public class OrderSystem
{
    public void PlaceOrder(string product, int quantity)
    {
        Console.WriteLine($"Order placed: {quantity} x {product}");
    }

    public void CancelOrder(string product)
    {
        Console.WriteLine($"Order cancelled: {product}");
    }
}