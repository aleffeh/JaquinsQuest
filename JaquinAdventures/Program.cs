using Autofac;
using JaquinAdventures.Core.Containers;
using JaquinAdventures.Interfaces;

namespace JaquinAdventures
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var container = ContainerConfig.Configure();

            using (var scope = container.BeginLifetimeScope())
            {
                var app = scope.Resolve<IApplication>();
                app.Run();
            }
        }
    }
}