using System;

namespace DesignPattern.Behavioral.ObserverPattern.ExampleUsage
{
    public class GameManager
    {
        public void CheckGameOver(int currentHealth)
        {
            if (currentHealth <= 0)
            {
                Console.WriteLine("Game Over! Player is dead.");
            }
        }
    }
}