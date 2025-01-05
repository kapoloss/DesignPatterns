using UnityEngine;

namespace DesignPattern.Structural.BridgePattern.ExampleUsage;

//Abstraction
public abstract class PlayerController
{
    protected IInputHandler inputHandler;

    public PlayerController(IInputHandler inputHandler)
    {
        this.inputHandler = inputHandler;
    }

    public abstract void Move();
    public abstract void Jump();
}

