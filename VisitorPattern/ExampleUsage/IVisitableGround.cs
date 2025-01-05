namespace DesignPattern.Behavioral.VisitorPattern.ExampleUsage
{
    public interface IVisitableGround
    {
        void Accept(IGroundVisitor visitor);
    }
}