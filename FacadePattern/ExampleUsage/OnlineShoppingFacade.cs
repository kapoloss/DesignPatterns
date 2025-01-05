using System;

namespace DesignPattern.Structural.FacadePattern.ExampleUsage;

// Facade class
public class OnlineShoppingFacade
{
    private readonly OrderSystem _orderSystem;
    private readonly PaymentSystem _paymentSystem;
    private readonly ShippingSystem _shippingSystem;

    public OnlineShoppingFacade(OrderSystem orderSystem, PaymentSystem paymentSystem, ShippingSystem shippingSystem)
    {
        _orderSystem = orderSystem;
        _paymentSystem = paymentSystem;
        _shippingSystem = shippingSystem;
    }

    public void PlaceOrder(string product, int quantity, string paymentMethod, decimal amount)
    {
        Console.WriteLine("Placing order...");
        _orderSystem.PlaceOrder(product, quantity);
        _paymentSystem.ProcessPayment(paymentMethod, amount);
        _shippingSystem.ArrangeShipping(product);
        Console.WriteLine("Order successfully placed!\n");
    }

    public void CancelOrder(string product, decimal refundAmount)
    {
        Console.WriteLine("Cancelling order...");
        _orderSystem.CancelOrder(product);
        _paymentSystem.RefundPayment(refundAmount);
        _shippingSystem.CancelShipping(product);
        Console.WriteLine("Order successfully cancelled!\n");
    }
}