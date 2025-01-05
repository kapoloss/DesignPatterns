using System;

namespace DesignPattern.Structural.FacadePattern.ExampleUsage;

public class PaymentSystem
{
    public void ProcessPayment(string paymentMethod, decimal amount)
    {
        Console.WriteLine($"Payment processed: {amount:C} via {paymentMethod}");
    }

    public void RefundPayment(decimal amount)
    {
        Console.WriteLine($"Payment refunded: {amount:C}");
    }
}