using Autofac;
using JaquinAdventures.Components;
using JaquinAdventures.Entities;
using JaquinAdventures.Scenes;
using Otter;

namespace JaquinAdventures
{
    public class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();
            
            builder.RegisterType<GameManager>().As<IApplication>();
            builder.RegisterInstance(new Game("Jaquin Adventures", 1280, 720)
                {Color = Color.Cyan});
            
            builder.RegisterType<MainScene>();
            builder.RegisterType<Player>();
            builder.RegisterInstance(Game.Instance.Input);
            builder.RegisterType<MoveSystemWithSprint>().As<IMoveSystem>();
            
            return builder.Build();
        }
    }
}