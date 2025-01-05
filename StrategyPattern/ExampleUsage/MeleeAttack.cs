using UnityEngine;

namespace DesignPattern.Behavioral.StrategyPattern.ExampleUsage
{
    public class MeleeAttack : IAttackStrategy
    {
        public void ExecuteAttack(Transform enemy, Transform player)
        {
            Debug.Log("Melee Attack: Enemy is attacking the player with a sword!");
        }
    }
    
    public class RangedAttack : IAttackStrategy
    {
        public void ExecuteAttack(Transform enemy, Transform player)
        {
            Debug.Log("Ranged Attack: Enemy is shooting an arrow!");
        }
    }
    
    public class EvadeAndTrap : IAttackStrategy
    {
        public void ExecuteAttack(Transform enemy, Transform player)
        {
            Debug.Log("Evade and Trap: Enemy is running away and placing traps!");
        }
    }
}