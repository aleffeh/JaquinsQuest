using JaquinAdventures.Abstractions;
using JaquinAdventures.Entities;
using Otter;

namespace JaquinAdventures.Components
{
    public class Movement : Component, IMovement
    {
        private readonly IInputHandler inputHandler;
        private float speed = 10;

        public Movement(IInputHandler inputHandler) => this.inputHandler = inputHandler;

        public override void Update() => Move();

        public void Move() => Entity.Position += inputHandler.GetDirection(speed);
    }
}