using Autofac;
using JaquinAdventures.Components;
using JaquinAdventures.Entities;
using JaquinAdventures.Interfaces;
using JaquinAdventures.Scenes;
using Otter;

namespace JaquinAdventures.Core.Containers
{
    public static class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();
            
            builder.RegisterType<GameManager>().As<IApplication>();
            
            builder.RegisterInstance(new Game("Jaquin Adventures", 1280, 720,120)
                {
                Color = Color.Magenta,
                MouseVisible = true
                }).SingleInstance();
            builder.RegisterInstance(Game.Instance.Input);
            
            builder.RegisterType<MainScene>().AsSelf();
            builder.RegisterType<Player>().SingleInstance();
            builder.RegisterType<ButtonBase>();
            builder.RegisterType<ClampComponent<Player>>();
            builder.RegisterType<Entities.Button>();
            
            builder.RegisterType<WasdInput>().As<IInputHandler>();
            
            builder.RegisterType<MovementWithSprint>().As<IMovement>();
            
            return builder.Build();
        }
    }
}