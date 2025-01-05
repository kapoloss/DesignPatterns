namespace DesignPattern.Behavioral.VisitorPattern.ExampleUsage
{
    public interface IGroundVisitor
    {
        void Visit(GrassGround grass);
        void Visit(IceGround ice);
        void Visit(LavaGround lava);
        void Visit(WaterGround water);
    }
}