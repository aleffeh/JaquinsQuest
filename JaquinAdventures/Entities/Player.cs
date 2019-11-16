using System;
using Autofac.Core;
using JaquinAdventures.Components;
using JaquinAdventures.Factories;
using JaquinAdventures.Interfaces;
using Otter;

namespace JaquinAdventures.Entities
{
    public class Player : Entity
    {
        public Bullet.Factory BulletFactory { get; set; }
        public ClampComponent<Player> ClampComponent { get; set; } 
        public IMovement Movement { get; set; }
        public Image Sprite { get; set; }

        public Player()
        {
            Sprite = Image.CreateCircle(64, Color.White);
            OnRender += OnRenderGraphic;
        }

        public override void Start()
        {
            AddComponent((Component) Movement);
            AddComponent(ClampComponent);

        }

        public void Shoot()
        {
            Scene.Add(BulletFactory.Invoke(new Vector2(1,1),Position,300,10,5 ));
        }

        private void OnRenderGraphic()
        {
            if (Graphic == Sprite) return;
            RemoveGraphic(Graphic);
            AddGraphic(Sprite);
        }

        public override void Render()
        {
            Sprite.Render(X, Y);
            base.Render();
        }
    }
}