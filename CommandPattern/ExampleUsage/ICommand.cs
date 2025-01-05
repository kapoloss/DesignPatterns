namespace  DesignPattern.Behavioral.CommandPattern.ExampleUsage
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}