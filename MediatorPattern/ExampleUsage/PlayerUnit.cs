using System;

namespace DesignPattern.Behavioral.MediatorPattern.ExampleUsage
{
    public class PlayerUnit : Unit
    {
        public PlayerUnit(string name, int health, int attackPower) 
            : base(name, health, attackPower) { }

        public override void PerformAction()
        {
            Console.WriteLine($"{Name}'s turn. Choose an action: Attack or Move");
            string action = Console.ReadLine();

            if (action == "Attack")
            {
                gameController.Notify(this, "Attack");
            }
            else if (action == "Move")
            {
                gameController.Notify(this, "Move", "B3");
            }
        }
    }
    
    public class EnemyUnit : Unit
    {
        public EnemyUnit(string name, int health, int attackPower) 
            : base(name, health, attackPower) { }

        public override void PerformAction()
        {
            Console.WriteLine($"{Name} (Enemy) decides to attack!");
            gameController.Notify(this, "Attack");
        }
    }
}