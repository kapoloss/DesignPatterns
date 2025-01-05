namespace DesignPattern.Creational.FactoryPattern.ExampleUsage
{
    public class EspressoFactory : CoffeeFactory
    {
        public override ICoffee CreateCoffee() => new Espresso();
    }

    public class CappuccinoFactory : CoffeeFactory
    {
        public override ICoffee CreateCoffee() => new Cappuccino();
    }

    public class LatteFactory : CoffeeFactory
    {
        public override ICoffee CreateCoffee() => new Latte();
    }
}