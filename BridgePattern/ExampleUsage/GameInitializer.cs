using UnityEngine;

namespace DesignPattern.Structural.BridgePattern.ExampleUsage;

//Client
public class GameInitializer : MonoBehaviour
{
    public CharacterController firstPersonCharacter;
    public Rigidbody thirdPersonRigidbody;

    private void Start()
    {
        PlayerController player;

        if (Application.platform == RuntimePlatform.WindowsPlayer || Application.platform == RuntimePlatform.WindowsEditor)
        {
            player = new FirstPersonController(new PCInputHandler(), firstPersonCharacter);
        }
        else if (Application.platform == RuntimePlatform.Android || Application.platform == RuntimePlatform.IPhonePlayer)
        {
            player = new ThirdPersonController(new MobileInputHandler(), thirdPersonRigidbody);
        }
        else
        {
            player = new ThirdPersonController(new GamepadInputHandler(), thirdPersonRigidbody);
        }

        player.Move();
        player.Jump();
    }
}