using Otter;

namespace JaquinAdventures.Interfaces
{
    public class MovementIA : Component, IMovement
    {
        public override void Update()
        {
            Move();          
        }
     
        
        public void Move()
        {
            Entity.X++;
        }
    }
}