using Autofac;
using JaquinAdventures.Entities;
using JaquinAdventures.Interfaces;
using JaquinAdventures.Scenes;
using Otter;

namespace JaquinAdventures.Core.Containers
{
    public class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();
            
            builder.RegisterType<GameManager>().As<IApplication>();
            
            builder.RegisterInstance(new Game("Jaquin Adventures", 1280, 720,120)
                {Color = Color.Cyan}).SingleInstance();
            builder.RegisterInstance(Game.Instance.Input);
            
            builder.RegisterType<MainScene>();
            builder.RegisterType<Player>();
            builder.RegisterType<MovementWithSprint>().As<IMovement>();
            builder.RegisterType<WasdInput>().As<IInputHandler>();
            
            return builder.Build();
        }
    }
}