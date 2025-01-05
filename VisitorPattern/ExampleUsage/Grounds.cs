using UnityEngine;

namespace DesignPattern.Behavioral.VisitorPattern.ExampleUsage
{
    public class GrassGround : MonoBehaviour, IVisitableGround
    {
        public void Accept(IGroundVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    public class IceGround : MonoBehaviour, IVisitableGround
    {
        public void Accept(IGroundVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    public class LavaGround : MonoBehaviour, IVisitableGround
    {
        public void Accept(IGroundVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    public class WaterGround : MonoBehaviour, IVisitableGround
    {
        public void Accept(IGroundVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}