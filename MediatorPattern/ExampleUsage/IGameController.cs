namespace DesignPattern.Behavioral.MediatorPattern.ExampleUsage
{
    public interface IGameController
    {
        void Notify(Unit sender, string eventCode, object data = null);
    }
}