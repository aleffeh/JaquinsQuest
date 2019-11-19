using System;
using Autofac.Core;
using JaquinAdventures.Components;
using JaquinAdventures.Factories;
using JaquinAdventures.Abstractions;
using Otter;

namespace JaquinAdventures.Abstractions
{
    public class Player : Entity
    {
        public Bullet.Factory BulletFactory { get; set; }
        public ClampComponent<Player> ClampComponent { get; set; } 
        public IMovement Movement { get; set; }
        public Image Sprite { get; set; }

        private Vector2 _shootPos;

        public Player()
        {
            Sprite = Image.CreateCircle(64, Color.White);
            OnRender += OnRenderGraphic;
            
        }

        public override void Start()
        {
            AddComponent((Component) Movement);
            AddComponent(ClampComponent);

            _shootPos = new Vector2(Graphic.HalfWidth,Graphic.HalfHeight);

        }

        public void Shoot()
        {
            Scene.Add(BulletFactory.Invoke(new Vector2(1,1),_shootPos,300,10,5,5
            ));
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