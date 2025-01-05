using System;

namespace DesignPattern.Behavioral.MediatorPattern.ExampleUsage
{
    public abstract class Unit
    {
        protected IGameController gameController;
        public string Name { get; private set; }
        public int Health { get; private set; }
        public int AttackPower { get; private set; }

        public Unit(string name, int health, int attackPower)
        {
            Name = name;
            Health = health;
            AttackPower = attackPower;
        }

        public void SetGameController(IGameController controller)
        {
            gameController = controller;
        }

        public void TakeDamage(int damage)
        {
            Health -= damage;
            Console.WriteLine($"{Name} takes {damage} damage. Remaining health: {Health}");

            if (Health <= 0)
            {
                Console.WriteLine($"{Name} has been defeated!");
            }
        }

        public abstract void PerformAction();
    }
}