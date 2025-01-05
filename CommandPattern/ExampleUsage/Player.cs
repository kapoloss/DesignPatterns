using UnityEngine;

namespace DesignPattern.Behavioral.CommandPattern.ExampleUsage
{
    public class Player
    {
        public Vector3 Position { get; private set; }

        public void Move(Vector3 direction)
        {
            Position += direction;
            Debug.Log($"Player moved to {Position}");
        }

        public void MoveBack(Vector3 direction)
        {
            Position -= direction;
            Debug.Log($"Player moved back to {Position}");
        }
    }
}