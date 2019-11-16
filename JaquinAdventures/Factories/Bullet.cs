using System;
using JaquinAdventures.Interfaces;
using Otter;

namespace JaquinAdventures.Factories
{
    public class Bullet : Entity, IDisposable
    {
        private Vector2 _direction;
        private float _speed;

        public delegate Bullet Factory(Vector2 direction, Vector2 position, float lifespan, float velocity, int radius,
            Image sprite = null);

    
        public Bullet(Vector2 direction, Vector2 position, float lifespan, float velocity, int radius,bool isTrigger = false,
            Image sprite = null)
        {
            X = position.X;
            Y = position.Y;

            Graphic = sprite ?? Image.CreateCircle(radius);
            Graphic.CenterOrigin();
            Collider = new CircleCollider(Graphic.Height);
            
            Collider.CenterOrigin();

            _direction = direction;
            _speed = velocity;
            LifeSpan = lifespan;
            
        }

        public override void Update()
        {
            X += _direction.X * _speed * Game.DeltaTime;
            Y += _direction.Y * _speed * Game.DeltaTime;
        }

        public void Dispose()
        {
            Console.WriteLine("Disposed");
        }
    }
}