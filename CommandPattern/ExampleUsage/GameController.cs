using UnityEngine;

namespace DesignPattern.Behavioral.CommandPattern.ExampleUsage
{
    public class GameController : MonoBehaviour
    {
        private CommandManager _commandManager;
        private Player _player;

        private void Start()
        {
            _commandManager = new CommandManager();
            _player = new Player();
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                ICommand moveForward = new MoveCommand(_player, Vector3.forward);
                _commandManager.ExecuteCommand(moveForward);
            }
            else if (Input.GetKeyDown(KeyCode.S))
            {
                ICommand moveBackward = new MoveCommand(_player, Vector3.back);
                _commandManager.ExecuteCommand(moveBackward);
            }
            else if (Input.GetKeyDown(KeyCode.U))
            {
                _commandManager.UndoLastCommand();
            }
        }
    }
}