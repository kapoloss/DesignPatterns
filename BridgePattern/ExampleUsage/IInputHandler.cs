using UnityEngine;

namespace DesignPattern.Structural.BridgePattern.ExampleUsage;

//Implementer
public interface IInputHandler
{
    Vector3 GetMovementInput();
    bool IsJumping();
}