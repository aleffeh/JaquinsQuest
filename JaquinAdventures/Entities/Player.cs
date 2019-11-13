using JaquinAdventures.Interfaces;
using Otter;

namespace JaquinAdventures.Entities
{
    public class Player : Entity
    {
        public Image Sprite { get; set; }
        
        public Player(IMovement movement)
        {
            AddComponent((Component)movement);
            
            Sprite = Image.CreateCircle(64, Color.White);
        }

        public override void Render()
        {
            Sprite.Render(X,Y);
            base.Render();
        }
    }
}