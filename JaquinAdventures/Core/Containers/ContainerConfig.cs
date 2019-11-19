using Autofac;
using JaquinAdventures.Components;
using JaquinAdventures.Factories;
using JaquinAdventures.Abstractions;
using JaquinAdventures.Entities;
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
            
            //Instantiate all th
            builder.RegisterInstance(new Game("Jaquin Adventures", 1280, 720,120)
                {
                Color = Color.FromBytes(149, 202, 252),
                MouseVisible = true
                }).SingleInstance();
            
            builder.RegisterInstance(Game.Instance.Input);
            builder.RegisterInstance(Game.Instance.Coroutine);
            builder.RegisterInstance(Game.Instance.Debugger);
            builder.RegisterInstance(Game.Instance.Tweener);
            
            builder.RegisterType<MainScene>().AsSelf().PropertiesAutowired();
            builder.RegisterType<Player>().SingleInstance().PropertiesAutowired();
            builder.RegisterType<ButtonBase>();
            builder.RegisterType<ClampComponent<Player>>();
            builder.RegisterType<ClickHandler>().As<IClickHandler>();
            builder.RegisterType<Entities.Button>();
            builder.RegisterType<ButtonComponent>().PropertiesAutowired();
            builder.RegisterType<Bullet>();
            
            builder.RegisterType<WasdInput>().As<IInputHandler>();
            
            builder.RegisterType<MovementWithSprint>().As<IMovement>();
            
            return builder.Build();
        }
    }
}