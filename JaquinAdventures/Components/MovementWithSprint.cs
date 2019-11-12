using Otter;

namespace JaquinAdventures.Interfaces
{
    public class MovementWithSprint : Component, IMovement
    {
        private float _speedMultiplier = 1;
        private readonly IInputHandler _inputHandler;
        private float _speed = 10;

        public MovementWithSprint(IInputHandler inputHandler) => _inputHandler = inputHandler;

        public override void Update()
        {
            _speedMultiplier = _inputHandler.Input.KeyDown(Key.Space) ? 2 : 1;
            Move();
        }

        public void Move() => Entity.Position += _inputHandler.GetDirection(_speed * _speedMultiplier);
    }
}