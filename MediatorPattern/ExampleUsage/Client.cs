using System.Reflection;

namespace DesignPattern.Behavioral.MediatorPattern.ExampleUsage
{
    public class Client
    {
        public void Run()
        {
            GameController gameController = new GameController();

            PlayerUnit player1 = new PlayerUnit("Knight", 100, 20);
            PlayerUnit player2 = new PlayerUnit("Archer", 80, 15);
            EnemyUnit enemy1 = new EnemyUnit("Orc", 120, 25);
            EnemyUnit enemy2 = new EnemyUnit("Goblin", 60, 10);

            gameController.RegisterUnit(player1);
            gameController.RegisterUnit(player2);
            gameController.RegisterUnit(enemy1);
            gameController.RegisterUnit(enemy2);

            while (true)
            {
                gameController.CurrentUnit().PerformAction();
            }
        }
    }
}