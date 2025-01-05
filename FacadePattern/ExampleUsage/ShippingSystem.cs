using System;

namespace DesignPattern.Structural.FacadePattern.ExampleUsage;

public class ShippingSystem
{
    public void ArrangeShipping(string product)
    {
        Console.WriteLine($"Shipping arranged for: {product}");
    }

    public void CancelShipping(string product)
    {
        Console.WriteLine($"Shipping cancelled for: {product}");
    }
}
