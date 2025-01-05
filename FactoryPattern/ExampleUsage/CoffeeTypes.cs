namespace DesignPattern.Creational.FactoryPattern.ExampleUsage
{
    public class Espresso : ICoffee
    {
        public string Prepare() => "Preparing Espresso";
    }

    public class Cappuccino : ICoffee
    {
        public string Prepare() => "Preparing Cappuccino";
    }

    public class Latte : ICoffee
    {
        public string Prepare() => "Preparing Latte";
    }
}