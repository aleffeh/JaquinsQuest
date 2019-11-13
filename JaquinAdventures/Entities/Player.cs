using JaquinAdventures.Components;
using JaquinAdventures.Interfaces;
using Otter;

namespace JaquinAdventures.Entities
{
    public class Player : Entity
    {
        public Image Sprite { get; set; }

        public Player(IMovement movement, ClampComponent<Player> clampComponent)
        {
            AddComponent((Component) movement);
            AddComponent(clampComponent);

            Sprite = Image.CreateCircle(64, Color.White);
            OnRender += OnRenderGraphic;
        }

        private void OnRenderGraphic()
        {
            if (Graphic != Sprite)
            {
                RemoveGraphic(Graphic);
                AddGraphic(Sprite);
            }
        }

        public override void Render()
        {
            Sprite.Render(X, Y);
            base.Render();
        }
    }
}