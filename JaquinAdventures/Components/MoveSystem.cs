using Otter;

namespace JaquinAdventures.Components
{
    public class MoveSystem : Component, IMoveSystem
    {
        private Input _input;

        public MoveSystem(Input input) => _input = input;

        public override void Update()
        {
            Move();
        }

        public void Move()
        {
            if (_input.KeyDown(Key.W))
                Entity.Y -= 10;
            if (_input.KeyDown(Key.S))
                Entity.Y += 10;
            if (_input.KeyDown(Key.D))
                Entity.X += 10;
            if (_input.KeyDown(Key.A))
                Entity.X -= 10;
        }
    }
}