namespace DesignPattern.Creational.AbstractFactoryPattern.ExampleUsage
{
    public class HotCoffeeFactory : ICoffeeFactory
    {
        public ICoffee CreateCoffee1() => new Espresso();
        public ICoffee CreateCoffee2() => new Cappuccino();
    }

    public class ColdCoffeeFactory : ICoffeeFactory
    {
        public ICoffee CreateCoffee1() => new IcedLatte();
        public ICoffee CreateCoffee2() => new ColdBrew();
    }
}