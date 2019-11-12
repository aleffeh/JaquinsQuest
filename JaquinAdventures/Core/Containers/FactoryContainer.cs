using Autofac;

namespace JaquinAdventures.Core.Containers
{
    public class FactoryContainer
    {
        public static IContainer Configure(IContainer gameContainer)
        {
            var builder = new ContainerBuilder();
            builder.RegisterInstance(gameContainer);
            return builder.Build();
        }
    }
}