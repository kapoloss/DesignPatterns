using System;

namespace DesignPattern.Behavioral.ObserverPattern.ExampleUsage
{
    public class HealthBar
    {
        public void UpdateHealthBar(int currentHealth)
        {
            Console.WriteLine($"HealthBar updated: Current health = {currentHealth}");
        }
    }
}