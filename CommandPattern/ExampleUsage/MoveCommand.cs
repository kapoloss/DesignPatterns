using UnityEngine;

namespace DesignPattern.Behavioral.CommandPattern.ExampleUsage
{
    public class MoveCommand : ICommand
    {
        private readonly Player _player;
        private readonly Vector3 _direction;

        public MoveCommand(Player player, Vector3 direction)
        {
            _player = player;
            _direction = direction;
        }

        public void Execute()
        {
            _player.Move(_direction);
        }

        public void Undo()
        {
            _player.MoveBack(_direction);
        }
    }
}