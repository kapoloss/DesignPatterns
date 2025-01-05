using UnityEngine;

namespace DesignPattern.Behavioral.VisitorPattern.ExampleUsage
{
    public class PlayerGroundInteractionVisitor : IGroundVisitor
    {
        public void Visit(GrassGround grass)
        {
            Debug.Log("Player is walking on grass. Normal speed.");
        }

        public void Visit(IceGround ice)
        {
            Debug.Log("Player is sliding on ice. Movement is slippery!");
        }

        public void Visit(LavaGround lava)
        {
            Debug.Log("Player is on lava! Taking damage...");
        }

        public void Visit(WaterGround water)
        {
            Debug.Log("Player is swimming. Movement speed reduced.");
        }
    }
}