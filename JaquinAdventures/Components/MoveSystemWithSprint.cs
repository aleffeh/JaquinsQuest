using Otter;

namespace JaquinAdventures.Components
{
    public class MoveSystemWithSprint : Component , IMoveSystem
    {
        private Input _input;
        private float _moveSpeed = 10f;
        private float _speedMultiplier = 1;

        public MoveSystemWithSprint(Input input)
        {
            _input = input;
        }
        
        public override void Update()
        {
            _speedMultiplier = _input.KeyDown(Key.Space) ? 2 : 1;

            Move();
        }

        public void Move()
        {
            if (_input.KeyDown(Key.W))
                Entity.Y -= _moveSpeed * _speedMultiplier;
            if (_input.KeyDown(Key.S))
                Entity.Y += _moveSpeed * _speedMultiplier;
            if (_input.KeyDown(Key.D))
                Entity.X += _moveSpeed * _speedMultiplier;
            if (_input.KeyDown(Key.A))
                Entity.X -= _moveSpeed * _speedMultiplier;
        }
    }
}