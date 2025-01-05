namespace DesignPattern.Structural.FacadePattern.ExampleUsage;

public class Usage
{
    public void Method()
    {
        var orderSystem = new OrderSystem();
        var paymentSystem = new PaymentSystem();
        var shippingSystem = new ShippingSystem();

        var onlineShopping = new OnlineShoppingFacade(orderSystem, paymentSystem, shippingSystem);

        onlineShopping.PlaceOrder("Laptop", 1, "Credit Card", 1200.00m);

        onlineShopping.CancelOrder("Laptop", 1200.00m);
    }
}