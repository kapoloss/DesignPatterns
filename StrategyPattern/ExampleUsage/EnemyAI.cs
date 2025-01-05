using UnityEngine;

namespace DesignPattern.Behavioral.StrategyPattern.ExampleUsage
{
    public class EnemyAI : MonoBehaviour
    {
        private IAttackStrategy _attackStrategy;

        public void SetAttackStrategy(IAttackStrategy attackStrategy)
        {
            _attackStrategy = attackStrategy;
        }

        public void PerformAttack(Transform player)
        {
            if (_attackStrategy != null)
            {
                _attackStrategy.ExecuteAttack(transform, player);
            }
            else
            {
                Debug.LogWarning("Attack strategy is not set!");
            }
        }
    }
}