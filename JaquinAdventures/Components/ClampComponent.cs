using Otter;

namespace JaquinAdventures.Components
{
    public class ClampComponent<T> : Component where T: Entity
    {
        private readonly Game game;

        public ClampComponent(Game game) => this.game = game;

        public override void Update()
        {
            if(Entity.Graphic == null)
                return;
            
            Entity.X = MathHelper.Clamp(Entity.X, 0, game.WindowWidth - Entity.Graphic.Width);
            Entity.Y = MathHelper.Clamp(Entity.Y, 0, game.WindowHeight - Entity.Graphic.Height);
            base.Update();
        }
    }
}