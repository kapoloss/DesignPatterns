using UnityEngine;

namespace DesignPattern.Behavioral.ChainOfResponsibility.ExampleUsage
{
    public class ArmorHandler : DamageHandler
    {
        public override void HandleDamage(Enemy enemy, float damage)
        {
            if (enemy.Armor > 0)
            {
                float reducedDamage = damage - enemy.Armor;
                reducedDamage = Mathf.Max(reducedDamage, 0);
                Debug.Log($"Armor absorbed some damage. Final Damage: {reducedDamage}");
                enemy.Health -= reducedDamage;
            }
            else
            {
                nextHandler?.HandleDamage(enemy, damage);
            }
        }
    }

    public class ResistanceHandler : DamageHandler
    {
        public override void HandleDamage(Enemy enemy, float damage)
        {
            if (enemy.IsResistant)
            {
                float reducedDamage = damage * 0.5f; 
                Debug.Log($"Resistance reduced the damage. Final Damage: {reducedDamage}");
                enemy.Health -= reducedDamage;
            }
            else
            {
                nextHandler?.HandleDamage(enemy, damage);
            }
        }
    }

    public class RageHandler : DamageHandler
    {
        public override void HandleDamage(Enemy enemy, float damage)
        {
            enemy.Health -= damage;

            if (enemy.Health <= enemy.RageThreshold)
            {
                enemy.IsRaging = true;
                Debug.Log("Enemy is raging!");
            }

            nextHandler?.HandleDamage(enemy, damage);
        }
    }
}