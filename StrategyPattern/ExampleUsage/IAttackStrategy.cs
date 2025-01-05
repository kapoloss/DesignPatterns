using UnityEngine;

namespace DesignPattern.Behavioral.StrategyPattern.ExampleUsage
{
    public interface IAttackStrategy
    {
        void ExecuteAttack(Transform enemy, Transform player);
    }
}