using JaquinAdventures.Interfaces;
using Otter;

namespace JaquinAdventures.Components
{
    public class MovementWithSprint : Component, IMovement
    {
        private float _speedMultiplier = 1;
        private readonly IInputHandler _inputHandler;
        private const float Speed = 10;
        private Game _game;

        public MovementWithSprint(IInputHandler inputHandler,Game game)
        {
            this._game = game;
            this._inputHandler = inputHandler;
        }

        public override void Update()
        {
            _speedMultiplier = _inputHandler.Input.KeyDown(Key.Space) ? 2 : 1;
            Move();
        }

        public void Move() => Entity.Position += _inputHandler.GetDirection(Speed * _speedMultiplier) * _game.DeltaTime ;
    }
}