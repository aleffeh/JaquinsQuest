using Otter;

namespace JaquinAdventures.Components
{
    public class IAMoveSystem : Component, IMoveSystem
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