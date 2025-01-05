using UnityEngine;

namespace DesignPattern.Structural.BridgePattern.ExampleUsage;

//ExtendedAbstraction
public class FirstPersonController : PlayerController
{
    private CharacterController characterController;

    public FirstPersonController(IInputHandler inputHandler, CharacterController characterController)
        : base(inputHandler)
    {
        this.characterController = characterController;
    }

    public override void Move()
    {
        Vector3 movement = inputHandler.GetMovementInput();
        characterController.Move(movement * Time.deltaTime * 5f);
    }

    public override void Jump()
    {
        if (inputHandler.IsJumping())
        {
            Debug.Log("First-Person Jump");
        }
    }
}

public class ThirdPersonController : PlayerController
{
    private Rigidbody rigidbody;

    public ThirdPersonController(IInputHandler inputHandler, Rigidbody rigidbody)
        : base(inputHandler)
    {
        this.rigidbody = rigidbody;
    }

    public override void Move()
    {
        Vector3 movement = inputHandler.GetMovementInput();
        rigidbody.MovePosition(rigidbody.position + movement * Time.deltaTime * 5f);
    }

    public override void Jump()
    {
        if (inputHandler.IsJumping())
        {
            Debug.Log("Third-Person Jump");
        }
    }
}
