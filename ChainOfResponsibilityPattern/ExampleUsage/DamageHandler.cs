namespace DesignPattern.Behavioral.ChainOfResponsibility.ExampleUsage
{
    public abstract class DamageHandler
    {
        protected DamageHandler nextHandler;

        public void SetNext(DamageHandler next)
        {
            nextHandler = next;
        }

        public abstract void HandleDamage(Enemy enemy, float damage);
    }
}