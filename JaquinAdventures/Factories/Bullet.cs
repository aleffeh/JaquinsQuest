using System;
using JaquinAdventures.Abstractions;
using Otter;

namespace JaquinAdventures.Factories
{
    public class Bullet : Entity
    {
        private readonly Vector2 _direction;
        private readonly float _speed;

        public delegate Bullet Factory(Vector2 direction, Vector2 position, float lifespan, float velocity, int radius,
            int layer, bool isTrigger = false, Image sprite = null, Collider collider = null);


        public Bullet(Vector2 direction, Vector2 position, float lifespan, float velocity, int radius, int layer,
            bool isTrigger = false, Image sprite = null, Collider collider = null)
        {
            X = position.X;
            Y = position.Y;

            Graphic = sprite ?? Image.CreateCircle(radius);
            Graphic.CenterOrigin();
            Collider = collider ?? new CircleCollider(Graphic.Height);
            Collider.Collidable = !isTrigger;
            Collidable = !isTrigger;
            Collider.CenterOrigin();

            _direction = direction;
            _speed = velocity;
            LifeSpan = lifespan;
            Layer = layer;
        }

        public override void Update()
        {
            X += _direction.X * _speed * Game.DeltaTime;
            Y += _direction.Y * _speed * Game.DeltaTime;
        }
    }
}