namespace DesignPattern.Creational.AbstractFactoryPattern.ExampleUsage
{
    public class Espresso : ICoffee
    {
        public string Prepare() => "Preparing Espresso";
    }

    public class Cappuccino : ICoffee
    {
        public string Prepare() => "Preparing Cappuccino";
    }

    public class IcedLatte : ICoffee
    {
        public string Prepare() => "Preparing Iced Latte";
    }

    public class ColdBrew : ICoffee
    {
        public string Prepare() => "Preparing Cold Brew";
    }
}