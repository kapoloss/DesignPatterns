using System;
using System.Collections.Generic;

namespace DesignPattern.Behavioral.MediatorPattern.ExampleUsage
{
    public class GameController : IGameController
    {
        private List<Unit> units = new List<Unit>();
        private int currentUnitIndex = 0;
        
        public void RegisterUnit(Unit unit)
        {
            units.Add(unit);
            unit.SetGameController(this);
        }
        public void Notify(Unit sender, string eventCode, object data = null)
        {
            switch (eventCode)
            {
                case "Attack":
                    Unit target = data as Unit;
                    if (target != null)
                    {
                        Console.WriteLine($"{sender.Name} attacks {target.Name}!");
                        target.TakeDamage(sender.AttackPower);
                    }
                    EndTurn();
                    break;

                case "Move":
                    string destination = data as string;
                    Console.WriteLine($"{sender.Name} moves to {destination}");
                    EndTurn();
                    break;

                default:
                    Console.WriteLine($"Unknown event: {eventCode}");
                    break;
            }
        }
        private void EndTurn()
        {
            currentUnitIndex = (currentUnitIndex + 1) % units.Count;
            Console.WriteLine($"It's now {units[currentUnitIndex].Name}'s turn!");
        }

        public Unit CurrentUnit()
        {
            return units[currentUnitIndex];
        }
    }
}