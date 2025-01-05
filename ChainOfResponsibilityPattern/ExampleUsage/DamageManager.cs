using UnityEngine;

namespace DesignPattern.Behavioral.ChainOfResponsibility.ExampleUsage
{
    public class DamageManager : MonoBehaviour
    {
        private void Start()
        {
            Enemy enemy = new Enemy(100, 10, true, 30);

            var armorHandler = new ArmorHandler();
            var resistanceHandler = new ResistanceHandler();
            var rageHandler = new RageHandler();

            armorHandler.SetNext(resistanceHandler);
            resistanceHandler.SetNext(rageHandler);

            Debug.Log($"Enemy Initial Health: {enemy.Health}");

            armorHandler.HandleDamage(enemy, 20);
            Debug.Log($"Enemy Health After Damage: {enemy.Health}");

            armorHandler.HandleDamage(enemy, 50);
            Debug.Log($"Enemy Health After Damage: {enemy.Health}");
        }
    }
}