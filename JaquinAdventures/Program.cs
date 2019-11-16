using Autofac;
using JaquinAdventures.Core.Containers;
using JaquinAdventures.Interfaces;

namespace JaquinAdventures
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Container = ContainerConfig.Configure();
            using (var scope = Container.BeginLifetimeScope())
            {
                var app = scope.Resolve<IApplication>();
                app.Run();
            }
        }

        public static IContainer Container { get; private set; }
    }
}