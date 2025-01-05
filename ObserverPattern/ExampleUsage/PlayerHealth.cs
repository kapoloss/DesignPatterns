using System;

namespace DesignPattern.Behavioral.ObserverPattern.ExampleUsage
{

    public class PlayerHealth
    {
        public delegate void HealthChanged(int currentHealth);
        public event HealthChanged OnHealthChanged;

        private int maxHealth;
        private int currentHealth;

        public PlayerHealth(int maxHealth)
        {
            this.maxHealth = maxHealth;
            currentHealth = maxHealth;
        }

        public void TakeDamage(int damage)
        {
            currentHealth -= damage;
            currentHealth = Math.Max(currentHealth, 0);
            Console.WriteLine($"Player took {damage} damage. Current health: {currentHealth}");

            OnHealthChanged?.Invoke(currentHealth);
        }

        public void Heal(int amount)
        {
            currentHealth += amount;
            currentHealth = Math.Min(currentHealth, maxHealth);
            Console.WriteLine($"Player healed {amount}. Current health: {currentHealth}");

            OnHealthChanged?.Invoke(currentHealth);
        }
    }
}