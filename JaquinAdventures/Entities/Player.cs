using JaquinAdventures.Components;
using Otter;

namespace JaquinAdventures.Entities
{
    public class Player : Entity
    {
        public Image Sprite { get; set; }
        
        public Player(IMoveSystem moveSystem)
        {
            AddComponent((Component)moveSystem);
            
            Sprite = Image.CreateCircle(64, Color.White);
            AddGraphic(Sprite);
        }
    }
}