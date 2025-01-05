using UnityEngine;

namespace DesignPattern.Structural.BridgePattern.ExampleUsage;

//ConcreteImplementationA
public class PCInputHandler : IInputHandler
{
    public Vector3 GetMovementInput()
    {
        return new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
    }

    public bool IsJumping()
    {
        return Input.GetKeyDown(KeyCode.Space);
    }
}
//ConcreteImplementationB
public class MobileInputHandler : IInputHandler
{
    public Vector3 GetMovementInput()
    {
        // Örnek: Sanal joystick ile hareket.
        return new Vector3(
            Input.GetAxis("Horizontal"), 
            0, 
            Input.GetAxis("Vertical")
        );
    }

    public bool IsJumping()
    {
        // Zıplama butonuna dokunma kontrolü.
        return Input.GetButtonDown("Jump");
    }
}
//ConcreteImplementationC
public class GamepadInputHandler : IInputHandler
{
    public Vector3 GetMovementInput()
    {
        return new Vector3(Input.GetAxis("GamepadHorizontal"), 0, Input.GetAxis("GamepadVertical"));
    }

    public bool IsJumping()
    {
        return Input.GetButtonDown("GamepadJump");
    }
}