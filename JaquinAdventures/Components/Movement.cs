using JaquinAdventures.Interfaces;
using Otter;

namespace JaquinAdventures.Components
{
    public class Movement : Component, IMovement
    {
        private readonly IInputHandler _inputHandler;
        private float _speed = 10;

        public Movement(IInputHandler inputHandler) => _inputHandler = inputHandler;

        public override void Update() => Move();

        public void Move() => Entity.Position += _inputHandler.GetDirection(_speed);
    }
}