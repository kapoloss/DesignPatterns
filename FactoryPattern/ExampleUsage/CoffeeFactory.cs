using System;

namespace DesignPattern.Creational.FactoryPattern.ExampleUsage
{
    public abstract class CoffeeFactory
    {
        public abstract ICoffee CreateCoffee();

        public void OrderCoffee()
        {
            ICoffee coffee = CreateCoffee();
            Console.WriteLine(coffee.Prepare());
        }
    }
}