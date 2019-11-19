using JaquinAdventures.Entities;
using Otter;

namespace JaquinAdventures.Abstractions
{
    class WasdInput : IInputHandler
    {
        public Input Input { get; }

        public WasdInput(Input input) => Input = input;

        public Vector2 GetDirection()
        {
            var direction = new Vector2();

            if (Input.KeyDown(Key.W))
                direction.Y -= 1;
            if (Input.KeyDown(Key.S))
                direction.Y += 1;
            if (Input.KeyDown(Key.D))
                direction.X += 1;
            if (Input.KeyDown(Key.A))
                direction.X -= 1;

            return direction;
        }

        public Vector2 GetDirection(float speed) => GetDirection() * speed;
    }
}