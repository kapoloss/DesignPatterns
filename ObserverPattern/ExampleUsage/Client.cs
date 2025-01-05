namespace DesignPattern.Behavioral.ObserverPattern.ExampleUsage
{
    public class Client
    {
        public void Run()
        {
            // Subject
            PlayerHealth playerHealth = new PlayerHealth(100);

            // Observers
            HealthBar healthBar = new HealthBar();
            GameManager gameManager = new GameManager();

            playerHealth.OnHealthChanged += healthBar.UpdateHealthBar;
            playerHealth.OnHealthChanged += gameManager.CheckGameOver;

            playerHealth.TakeDamage(30);
            playerHealth.TakeDamage(50);
            playerHealth.Heal(20);
            playerHealth.TakeDamage(40);
        }
    }
}