using JaquinAdventures.Abstractions;
using Otter;

namespace JaquinAdventures.Components
{
    public class MovementIa : Component, IMovement
    {
        public override void Update() => Move();
        public void Move() => Entity.X++;
    }
}