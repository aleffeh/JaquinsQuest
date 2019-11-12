using JaquinAdventures.Interfaces;
using Otter;

namespace JaquinAdventures.Components
{
    public class MovementWithSprint : Component, IMovement
    {
        private float speedMultiplier = 1;
        private readonly IInputHandler inputHandler;
        private readonly float speed = 10;

        public MovementWithSprint(IInputHandler inputHandler) => this.inputHandler = inputHandler;

        public override void Update()
        {
            speedMultiplier = inputHandler.Input.KeyDown(Key.Space) ? 2 : 1;
            Move();
        }

        public void Move() => Entity.Position += inputHandler.GetDirection(speed * speedMultiplier);
    }
}